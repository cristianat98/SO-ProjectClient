using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace Cliente
{
    public partial class Conexion : Form
    {
        Socket server;
        Thread atender;

        string username, password;
        string mensaje;
        int idpartida;
        int contador;

        byte[] msg;
        byte[] msg2;

        bool servidor = false;
        bool conectado = false;
        bool partida = false;
        bool jugando = false;
        bool aceptar = false;
        bool cartas = false;
        bool apuesta = false;
        bool acabado = false;

        List<string> conectados = new List<string>();
        List<string> invitados = new List<string>();
        List<string> jugadores = new List<string>();
        List<string> barajacartas = new List<string>();

        delegate void DelegadoParaInvitaciones();
        delegate void DelegadoParaActualizarLista(string[] nombres);
        delegate void DelegadoParaServidor(string mensaje);
        delegate void DelegadoParaTurno();
        delegate void DelegadoParaFormulario();
        delegate void DelegadoParaApuesta(int[] num);
        delegate void DelegadoParaLabels(string nombres);

        Registro fRegistro;
        Apuesta fApuesta;
        Thread crear;
        Thread T;
        Thread A;

        public Conexion()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (servidor)
            {
                if (conectado)
                {
                    if (partida)
                    {
                        if (partida)
                            mensaje = "11/" + idpartida + "/" + username;
                        
                        else
                            mensaje = "8/" + idpartida + "/" + username;
                    }


                    else
                        //Mensaje de desconexión
                        mensaje = "0/" + username;
                }
                else
                    mensaje = "9/";

                msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                atender.Abort();
                server.Shutdown(SocketShutdown.Both);
                server.Close();
                //fRegistro.Close();
            }
        }

        private void AtenderServidor()
        {
            while (true)
            {
                //Recibimos mensaje del servidor
                msg2 = new byte[500];
                server.Receive(msg2);
                string trozos = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                int codigo = Convert.ToInt32(trozos.Split(':')[0]);
                mensaje = trozos.Split(':')[1];
                switch (codigo)
                {
                    case 1:     //Registro
                        this.Invoke(new DelegadoParaServidor(Registrarse), new object[] { mensaje });
                        crear.Abort();
                        break;
                    case 2:     //Iniciar sesion
                        this.Invoke(new DelegadoParaServidor(IniciarSesion), new object[] { mensaje });
                        break;
                    case 3:     //mejor jugador
                        this.Invoke(new DelegadoParaServidor(Mejor_Jugador), new object[] { mensaje });
                        break;
                    case 4: //peor jugador
                        this.Invoke(new DelegadoParaServidor(Peor_Jugador), new object[] { mensaje });
                        break;
                    case 5: //Partida mas larga
                        this.Invoke(new DelegadoParaServidor(Partida_Larga), new object[] { mensaje });
                        break;
                    case 6:     //partida mas corta
                        this.Invoke(new DelegadoParaServidor(Partida_Corta), new object[] { mensaje });
                        break;

                    case 7:     //DameConectados
                        int num = Convert.ToInt32(mensaje.Split('/')[0]);
                        conectados.Clear();
                        if (num != 0)
                        {
                            listaConectados.Rows.Clear();
                            listaConectados.ColumnCount = 1;
                            listaConectados.RowCount = num;
                            string con;
                            for (int i = 0; i < num; i++)
                            {
                                con = mensaje.Split('/')[i + 1];
                                listaConectados.Rows[i].Cells[0].Value = con;
                                conectados.Add(con);
                            }
                        }

                        else
                        {
                            listaConectados.ColumnCount = 1;
                            listaConectados.RowCount = 1;
                            listaConectados.Rows[0].Cells[0].Value = "No Conectados";
                        }
                        break;

                    case 8:
                        {
                            bool encontrado = false;
                            if (Convert.ToInt32(mensaje.Split('/')[0]) > jugadores.Count)
                                encontrado = true;
                            int i = 0;
                            jugadores.Clear();
                            while (i<Convert.ToInt32(mensaje.Split('/')[0]))
                            {
                                jugadores.Add(mensaje.Split('/')[i + 1]);
                                i++;
                            }
                            this.Invoke(new DelegadoParaLabels(ActualizarLabels), new object[] { mensaje });
                            if (encontrado)
                            {
                                if (jugadores[jugadores.Count - 1] != username)
                                    MessageBox.Show(jugadores[jugadores.Count - 1] + " se ha unido a la partida.");

                                if (jugadores.Count == 4)
                                {
                                    MessageBox.Show("Ya sois 4 jugadores, así que ya podeis jugar.");
                                    jugando = true;
                                }
                            }
                            else
                            {
                                MessageBox.Show(mensaje.Split('/')[i + 1] + " ha abandonado la partida");
                                if (jugando)
                                {
                                    MessageBox.Show("La partida se termina, ya que el jugador se ha ido en mitad de la partida.");
                                    jugando = false;
                                    apuesta = false;
                                    if (acabado)
                                    {
                                        acabado = false;
                                        this.Invoke(new DelegadoParaFormulario(EmpezarCartas), new object[] { } );
                                    }
                                    contador = 0;
                                }
                                apuesta1.Text = "Cantidad Apostada:";
                                apuesta2.Text = "Cantidad Apostada:";
                                apuesta3.Text = "Cantidad Apostada:";
                                apuesta4.Text = "Cantidad Apostada:";
                            }
                        }

                        break;
                    
                    case 9:
                        {
                            if (Convert.ToInt32(mensaje.Split('/')[0]) == 0)
                                MessageBox.Show("No te has podido unir porque la partida está llena.");
                            else
                                MessageBox.Show(mensaje.Split('/')[1] + " no se ha podido unir porque la partida está llena.");
                        }
                        
                        break;

                    case 10:
                        {
                            if (Convert.ToInt32(mensaje.Split('/')[0]) == 0)
                            {
                                idpartida = Convert.ToInt32(mensaje.Split('/')[1]);
                                partida = true;
                                T.Abort();
                            }

                            else if (Convert.ToInt32(mensaje.Split('/')[0]) == 2)
                                 MessageBox.Show(mensaje.Split('/')[1] + " se ha unido a la partida.");

                            else
                               MessageBox.Show(mensaje.Split('/')[1] + " ha aceptado la partida.");
                        }

                        break;

                    case 11:
                        {
                            if (Convert.ToInt32(mensaje.Split('/')[0]) == 1)
                               MessageBox.Show(mensaje.Split('/')[1] + " ha rechazado la partida.");
                            else if (aceptar)
                            {
                                T.Abort();
                                aceptar = false;
                            }
                        }
                        break;

                    case 12:
                        this.Invoke(new DelegadoParaServidor(AceptarPartida), new object[] { mensaje });

                        break;
                    case 13:
                        EnviarChat.Invoke(new DelegadoParaServidor(PonerMensaje), new object[] { trozos });
                        break;

                    case 14:
                        if (Convert.ToInt32(mensaje.Split('/')[0]) == 0)
                        {
                            MessageBox.Show("Has abandonado la partida");
                            partida = false;
                            jugadores.Clear();
                        }

                        else
                            MessageBox.Show(mensaje.Split('/')[1] + " ha abandonado la partida.");

                        break;
                   
                    case 15:
                        if (Convert.ToInt32(mensaje.Split('/')[0]) == 0)
                        {
                            contador++;
                            apuesta = true;
                            A.Abort();
                            int[] numeros = new int[2];
                            int i = 0;
                            bool encontrado = false;
                            while (i < 4 && !encontrado)
                            {
                                if (username == jugadores[i])
                                    encontrado = true;
                                else
                                    i++;
                            }
                            if (encontrado)
                            {
                                numeros[0] = i;
                                numeros[1] = Convert.ToInt32(mensaje.Split('/')[1]);

                                this.Invoke(new DelegadoParaApuesta(ActualizarApuesta), new object[] { numeros });
                            }
                        }

                        else
                        {
                            int ap = Convert.ToInt32(mensaje.Split('/')[0]);
                            string user = mensaje.Split('/')[1];
                            bool encontrado = false;
                            int i = 0;
                            while (i < 4 && !encontrado)
                            {
                                if (user == jugadores[i])
                                    encontrado = true;
                                else
                                    i++;
                            }

                            if (encontrado)
                            {
                                MessageBox.Show(jugadores[i] + " ha hecho su apuesta.");
                                int[] numeros = new int[2];
                                numeros[0] = i;
                                numeros[1] = ap;

                                this.Invoke(new DelegadoParaApuesta(ActualizarApuesta), new object[] { numeros });
                                contador++;
                            }
                        }

                        if (contador == 4)
                        {
                            MessageBox.Show("Ya habéis hecho una apuesta los 4. Ahora se dará la vuelta a las cartas.");
                            if (!cartas)
                            {
                                StreamReader F = new StreamReader("cartas.txt");
                                int b = 0;
                                while (b < 48)
                                {
                                    barajacartas.Add(F.ReadLine());
                                    b++;
                                }
                                F.Close();
                                cartas = true;
                            }

                            if (jugadores[0] == username)
                            {
                                mensaje = "17/" + idpartida;
                                msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                                server.Send(msg);
                            }
                        }

                        break;

                    case 16:
                        this.Invoke(new DelegadoParaServidor(GirarCartas), new object[] { mensaje });

                        break;
                    case 18:
                        this.Invoke(new DelegadoParaServidor(DarseBaja), new object[] { mensaje });

                        break;
                    case 19:

                        if (mensaje != username)
                        {
                            this.Invoke(new DelegadoParaFormulario(EmpezarCartas), new object[] {  });
                            this.Invoke(new DelegadoParaLabels(ActualizarLabels), new object[] { Convert.ToString(5) });
                            MessageBox.Show(mensaje + " ha reiniciado la partida.");
                            acabado = false;
                            apuesta = false;
                            contador = 0;
                        }
                        break;
                    }
            }
        }

        public void EmpezarCartas()
        {
            Izq1.Image = Image.FromFile("Cartas/back.jpg");
            Centro1.Image = Image.FromFile("Cartas/back.jpg");
            Der1.Image = Image.FromFile("Cartas/back.jpg");
            Izq2.Image = Image.FromFile("Cartas/back.jpg");
            Centro2.Image = Image.FromFile("Cartas/back.jpg");
            Der2.Image = Image.FromFile("Cartas/back.jpg");
            Izq3.Image = Image.FromFile("Cartas/back.jpg");
            Centro3.Image = Image.FromFile("Cartas/back.jpg");
            Der3.Image = Image.FromFile("Cartas/back.jpg");
            Izq4.Image = Image.FromFile("Cartas/back.jpg");
            Centro4.Image = Image.FromFile("Cartas/back.jpg");
            Der4.Image = Image.FromFile("Cartas/back.jpg");
        }
        
        public void GirarCartas(string cartas)
        {
            Izq1.Image = Image.FromFile("Cartas/" + barajacartas[Convert.ToInt32(cartas.Split('/')[1])] + ".jpg");
            Centro1.Image = Image.FromFile("Cartas/" + barajacartas[Convert.ToInt32(cartas.Split('/')[2])] + ".jpg");
            Der1.Image = Image.FromFile("Cartas/" + barajacartas[Convert.ToInt32(cartas.Split('/')[3])] + ".jpg");
            Izq2.Image = Image.FromFile("Cartas/" + barajacartas[Convert.ToInt32(cartas.Split('/')[4])] + ".jpg");
            Centro2.Image = Image.FromFile("Cartas/" + barajacartas[Convert.ToInt32(cartas.Split('/')[5])] + ".jpg");
            Der2.Image = Image.FromFile("Cartas/" + barajacartas[Convert.ToInt32(cartas.Split('/')[6])] + ".jpg");
            Izq3.Image = Image.FromFile("Cartas/" + barajacartas[Convert.ToInt32(cartas.Split('/')[7])] + ".jpg");
            Centro3.Image = Image.FromFile("Cartas/" + barajacartas[Convert.ToInt32(cartas.Split('/')[8])] + ".jpg");
            Der3.Image = Image.FromFile("Cartas/" + barajacartas[Convert.ToInt32(cartas.Split('/')[9])] + ".jpg");
            Izq4.Image = Image.FromFile("Cartas/" + barajacartas[Convert.ToInt32(cartas.Split('/')[10])] + ".jpg");
            Centro4.Image = Image.FromFile("Cartas/" + barajacartas[Convert.ToInt32(cartas.Split('/')[11])] + ".jpg");
            Der4.Image = Image.FromFile("Cartas/" + barajacartas[Convert.ToInt32(cartas.Split('/')[12])] + ".jpg");
            int i = 0;
            int mejor = Convert.ToInt32(cartas.Split('/')[17]);
            int[] puntuacion = new int[4];
            while (i < 4)
            {
                puntuacion[i] = Convert.ToInt32(cartas.Split('/')[i + 13]);
                i++;
            }
            puntuacion1.Text = puntuacion1.Text + Convert.ToString(puntuacion[0]);
            puntuacion2.Text = puntuacion2.Text + Convert.ToString(puntuacion[1]);
            puntuacion3.Text = puntuacion3.Text + Convert.ToString(puntuacion[2]);
            puntuacion4.Text = puntuacion4.Text + Convert.ToString(puntuacion[3]);

            MessageBox.Show("Tu puntuación ha sido de " + puntuacion[Convert.ToInt32(cartas.Split('/')[0])] + " puntos.");
            if (mejor == puntuacion[Convert.ToInt32(cartas.Split('/')[0])])
                MessageBox.Show("Has ganado!!!");
            else
            {
                i = 0;
                bool encontrado = false;
                while (i < 4 && !encontrado)
                {
                    if (mejor == puntuacion[i])
                    {
                        encontrado = true;
                        MessageBox.Show("Ha ganado " + jugadores[i]);
                    }
                    else
                        i++;
                }
            }
            acabado = true;
        }
        
        public void ActualizarApuesta(int[] numeros)
        {
            switch (numeros[0])
            {
                case 0:
                    apuesta1.Text = apuesta1.Text + " " + Convert.ToString(numeros[1]);
                    break;

                case 1:
                    apuesta2.Text = apuesta2.Text + " " + Convert.ToString(numeros[1]);
                    break;

                case 2:
                    apuesta3.Text = apuesta3.Text + " " + Convert.ToString(numeros[1]);
                    break;

                case 3:
                    apuesta4.Text = apuesta4.Text + " " + Convert.ToString(numeros[1]);
                    break;
            }
        }
        
        private void CrearFormRegistro()
        {
            fRegistro = new Registro(server);
            fRegistro.ShowDialog();
            Thread.Sleep(1000);
        }

        public void ActualizarLabels(string nombre)
        {
            if (Convert.ToInt32(nombre.Split('/')[0]) == 1)
            {
                Jugador1.Text = jugadores[0];
                Jugador2.Text = "Jugador 2";
                Jugador3.Text = "Jugador 3";
                Jugador4.Text = "Jugador 4";
            }

            else if (Convert.ToInt32(nombre.Split('/')[0]) == 2)
            {
                Jugador1.Text = jugadores[0];
                Jugador2.Text = jugadores[1];
                Jugador3.Text = "Jugador 3";
                Jugador4.Text = "Jugador 4";
            }

            else if (Convert.ToInt32(nombre.Split('/')[0]) == 3)
            {
                Jugador1.Text = jugadores[0];
                Jugador2.Text = jugadores[1];
                Jugador3.Text = jugadores[2];
                Jugador4.Text = "Jugador 4";
            }

            else if (Convert.ToInt32(nombre.Split('/')[0]) == 4)
            {
                Jugador1.Text = jugadores[0];
                Jugador2.Text = jugadores[1];
                Jugador3.Text = jugadores[2];
                Jugador4.Text = jugadores[3];
            }

            else if (Convert.ToInt32(nombre.Split('/')[0]) == 5)
            {
                puntuacion1.Text = "Puntuacion:";
                puntuacion2.Text = "Puntuacion:";
                puntuacion3.Text = "Puntuacion:";
                puntuacion4.Text = "Puntuacion:";
                apuesta1.Text = "Cantidad Apostada:";
                apuesta2.Text = "Cantidad Apostada:";
                apuesta3.Text = "Cantidad Apostada:";
                apuesta4.Text = "Cantidad Apostada:";
            }
        }

        public void PonerMensaje(string frase)
        {
            string[] text = frase.Split(':');
            Chatgrande.AppendText(text[1] + ": " + text[2] + Environment.NewLine);
        }

        private void conectar_Click(object sender, EventArgs e)
        {
            if (servidor)
                MessageBox.Show("Ya estás conectado en un servidor.");
            else
            {
                //Creamos un IPEndPoint con el ip del servidor y puerto del servidor 
                //al que deseamos conectarnos

                //Desarrollo
                IPAddress direc = IPAddress.Parse("192.168.56.103");
                IPEndPoint ipep = new IPEndPoint(direc, 9215);

                //Shiva
                //IPAddress direc = IPAddress.Parse("147.83.117.22");
                //IPEndPoint ipep = new IPEndPoint(direc, 50021);


                //Creamos el socket 
                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                try
                {
                    server.Connect(ipep);//Intentamos conectar el socket
                    this.BackColor = Color.Green;
                    MessageBox.Show("Conectado");
                    servidor = true;
                    ThreadStart ts = delegate { AtenderServidor(); };
                    atender = new Thread(ts);
                    atender.Start();
                    mensaje = "7/";
                    msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                    server.Send(msg);
                }

                catch (SocketException)
                {
                    //Si hay excepcion imprimimos error y salimos del programa con return 
                    MessageBox.Show("No he podido conectar con el servidor");
                    return;
                }
            }
        }

        private void desconectar_Click(object sender, EventArgs e)
        {
            if (!servidor)
                MessageBox.Show("Ya estás desconectado.");
            else
            {
                if (conectado)
                {
                    if (partida)
                    {
                        if (jugando)
                        {
                            mensaje = "11/" + idpartida + "/" + username;
                            jugando = false;
                            if (acabado)
                            {
                                acabado = false;
                                this.Invoke(new DelegadoParaFormulario(EmpezarCartas), new object[] { });
                            }
                            else
                                mensaje = "8/" + idpartida + "/" + username;
                            partida = false;
                            jugadores.Clear();
                        }
                        //Mensaje de desconexión
                        else
                            mensaje = "0/" + username;

                        user.Text = "NO CONECTADO";
                        conectado = false;
                    }
                    else
                        mensaje = "9/";

                    msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                    server.Send(msg);

                    // Nos desconectamos
                    atender.Abort();
                    server.Shutdown(SocketShutdown.Both);
                    server.Close();
                    //fRegistro.Close();
                    this.BackColor = Color.Gray;
                    MessageBox.Show("Desconectado");
                    listaConectados.Rows.Clear();
                    servidor = false;
                    listaConectados.Rows[0].Cells[0].Value = "No Servidor";
                }
            }
        }

        private void Registro_Click_1(object sender, EventArgs e)
        {
            if (!servidor)
                MessageBox.Show("Debes conectarte primero con el servidor.");

            else
            {
                if (conectado)
                    MessageBox.Show("Ya estás conectado con un usuario.");

                else
                {
                    ThreadStart ts = delegate { CrearFormRegistro(); };
                    crear = new Thread(ts);
                    crear.Start();
                }
            }

        }

        public void Registrarse(string mensaje)
        {
            string[] texto = mensaje.Split('/');
            int registrado = Convert.ToInt32(mensaje.Split('/')[0]);
            if (registrado == 0)
            {
                username = mensaje.Split('/')[1];
                MessageBox.Show("Te has registrado con " + username);
                conectado = true;
                user.Text = username;
            }

            else if (registrado == 1)
                MessageBox.Show("El usuario ya está en uso.");

            else if (registrado == 2)
                MessageBox.Show("El nombre ya está en uso.");

            else
                MessageBox.Show("Error con la base de datos.");
        }

        private void inicia_sesion_Click(object sender, EventArgs e)
        {
            if (!servidor)
                MessageBox.Show("Primero debe conectarse con el servidor.");
            else
            {
                if (conectado)
                    MessageBox.Show("Ya estás conectado con un usuario.");
                else
                {
                    username = nombre.Text;
                    password = contraseña.Text;

                    if (username == "" || password == "")
                        MessageBox.Show("No se han introducido todos los datos.");

                    else
                    {

                        mensaje = "2/" + username + "/" + password;
                        msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                        server.Send(msg);
                    }
                }
            }
        }

        public void IniciarSesion(string mensaje)
        {
            int registrado = Convert.ToInt32(mensaje);
            if (registrado == 0)
            {
                MessageBox.Show("Te has conectado como " + username);
                conectado = true;
                user.Text = username;
                //fRegistro.Close();
            }

            else if (registrado == 1)
                MessageBox.Show("No te has podido registrar porque el servidor está lleno.");

            else if (registrado == 2)
                MessageBox.Show("El usuario ya está conectado.");

            else
                MessageBox.Show("El usuario no existe.");
        }

        private void mejor_jugador_Click(object sender, EventArgs e)
        {
            if (!servidor)
                MessageBox.Show("Primero debes conectarte con el servidor.");
            else
            {
                mensaje = "3/";
                msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);
            }
        }

        public void Mejor_Jugador(string mensaje)
        {
            if (mensaje == "2")
                MessageBox.Show("Error con la consulta.");

            else if (mensaje == "3")
                MessageBox.Show("No hay jugadores en la base de datos.");

            else
                MessageBox.Show("El mejor jugador es: " + mensaje);

        }

        private void peor_jugador_Click(object sender, EventArgs e)
        {
            if (!servidor)
                MessageBox.Show("Primero debes conectarte con el servidor.");
            else
            {
                mensaje = "4/";
                msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);
            }
        }

        public void Peor_Jugador(string mensaje)
        {
            if (mensaje == "2")
                MessageBox.Show("Error con la consulta.");

            else if (mensaje == "3")
                MessageBox.Show("No hay jugadores en la base de datos.");

            else
                MessageBox.Show("El peor jugador es: " + mensaje);
        }

        private void partida_larga_Click(object sender, EventArgs e)
        {
            if (!servidor)
                MessageBox.Show("Primero debes conectarte con el servidor.");
            else
            {
                mensaje = "5/";
                msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);
            }
        }

        public void Partida_Larga(string mensaje)
        {
            if (mensaje == "2")
                MessageBox.Show("Error con la consulta.");

            else if (mensaje == "3")
                MessageBox.Show("No hay partidas en la base de datos.");

            else
                MessageBox.Show("La partida mas larga corresponde a: " + mensaje);
        }

        private void partida_corta_Click(object sender, EventArgs e)
        {
            if (!servidor)
                MessageBox.Show("Primero debes conectarte con el servidor.");
            else
            {
                mensaje = "6/";
                msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);
            }
        }

        public void Partida_Corta(string mensaje)
        {
            if (mensaje == "2")
                MessageBox.Show("Error con la consulta.");

            else if (mensaje == "3")
                MessageBox.Show("No hay partidas en la base de datos.");

            else
                MessageBox.Show("La partida más corta corresponde a: " + mensaje);

        }

        private void invitar_Click(object sender, EventArgs e)
        {
            if (!servidor)
                MessageBox.Show("Primero debes conectarte con el servidor.");
            else
            {
                if (!conectado)
                    MessageBox.Show("Debes conectarte con un usuario.");

                else
                {
                    if (jugadores.Count < 4)
                    {
                        int numinv = listaConectados.SelectedRows.Count;
                        if (numinv == 0)
                            MessageBox.Show("No has seleccionado a ningún jugador.");

                        else
                        {
                            invitados.Clear();
                            int i = 0;
                            int pos;
                            string actual;
                            while (i < numinv)
                            {
                                pos = Convert.ToInt32(listaConectados.SelectedRows[i].Index);
                                actual = listaConectados.Rows[pos].Cells[0].Value.ToString();
                                int a = 0;
                                bool encontrado = false;
                                while (a < jugadores.Count && !encontrado)
                                {
                                    if (jugadores[a] == actual)
                                    {
                                        MessageBox.Show(actual + " ya está en tu partida.");
                                        encontrado = true;
                                    }
                                    else
                                        a++;
                                }
                                if (!encontrado)
                                {
                                    if (actual != username)
                                        invitados.Add(actual);
                                    else
                                        MessageBox.Show("No te puedes invitar a ti mismo.");
                                }

                                i++;
                            }
                            if (invitados.Count < 4 && invitados.Count != 0)
                            {
                                if (!partida)
                                {
                                    Random r = new Random();
                                    idpartida = r.Next(1, 999999);

                                    Jugador1.Text = username;
                                    partida = true;
                                }
                                i = 0;
                                mensaje = "12/" + idpartida + "/" + Convert.ToString(invitados.Count) + "/" + username;
                                // Enviamos al servidor el nombre tecleado
                                while (i < invitados.Count)
                                {
                                    mensaje = mensaje + "/" + invitados[i];
                                    i++;
                                }

                                msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                                server.Send(msg);
                            }

                            else if (invitados.Count > 3)
                                MessageBox.Show("No puedes invitar a mas de 3 jugadores.");
                            else
                                MessageBox.Show("Debes invitar a alguien.");
                        }
                    }

                    else
                        MessageBox.Show("Ya sois 4 jugadores. No puedes invitar a nadie mas.");
                }
            }
        }

        public void AceptarPartida(string frase)
        {
            if (partida)
            {
                MessageBox.Show(frase.Split('/')[0] + " te ha invitado a jugar otra partida, si quieres jugarla deberas abandonar la actual.");
                // No acepta jugar
                string mensaje8 = "15/" + idpartida + "/" + frase.Split('/')[0] + "/0";
                // Enviamos al servidor el nombre tecleado
                byte[] msg8 = System.Text.Encoding.ASCII.GetBytes(mensaje8);
                server.Send(msg8);
            }

            else
            {
                idpartida = Convert.ToInt32(frase.Split('/')[1]);
                aceptar = true;
                ThreadStart ts = delegate { PonerEnMarchaFormularioAceptar(frase); };
                T = new Thread(ts);
                T.Start();
            }
        }

        private void PonerEnMarchaFormularioAceptar(string mensaje)
        {
            Aceptar l = new Aceptar(server, mensaje);
            l.ShowDialog();
            Thread.Sleep(1000);
        }

        private void EnviarChat_Click(object sender, EventArgs e)
        {
            if (!servidor)
                MessageBox.Show("Primero debes conectarte con el servidor.");
            else
            {
                if (!conectado)
                    MessageBox.Show("Debes conectarte con un usuario.");
                else
                {
                    if (Chatpequeno.Text == "")
                        MessageBox.Show("Debe escribir un mensaje.");
                    else
                    {
                        string mensaje = "13/" + user.Text + ":" + Chatpequeno.Text;
                        // Enviamos al servidor el nombre tecleado
                        byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                        server.Send(msg);
                    }
                }
            }
            Chatpequeno.Text = "";
        }

        private void iniciojuego_Click(object sender, EventArgs e)
        {
            if (!servidor)
                MessageBox.Show("Primero debes conectarte con el servidor.");

            else
            {
                if (!conectado)
                    MessageBox.Show("Debes conectarte con un usuario.");

                else
                {
                    int faltajug = 4 - jugadores.Count;
                    if (faltajug != 0)
                        MessageBox.Show("Te faltan " + faltajug + " jugadores en la partida para poder jugar.");
                    else
                    {
                        if (!apuesta)
                        {
                            ThreadStart ts = delegate { CrearFormApuesta(); };
                            A = new Thread(ts);
                            A.Start();
                        }
                        else
                            MessageBox.Show("Ya has hecho la apuesta.");
                    }
                }
            }
        }

        public void CrearFormApuesta()
        {
            fApuesta = new Apuesta(server, idpartida);
            fApuesta.ShowDialog();
            Thread.Sleep(1000);
        }

        public void DarseBaja(string mensaje)
        {
            if (Convert.ToInt32(mensaje) == 1)
                MessageBox.Show("Ha habido algun error al darte de baja.");

            else
            {
                MessageBox.Show("Se te ha dado de baja correctamente.");
                conectado = false;
                user.Text = "NO CONECTADO";
            }
        }

        private void Baja_Click(object sender, EventArgs e)
        {
            if (!servidor)
                MessageBox.Show("Primero debes conectarte con el servidor.");
            else
            {
                if (!conectado)
                    MessageBox.Show("Debes conectarte con el usuario que quieres dar de baja.");
                else
                {
                    string mensaje = "18/" + username;
                    // Enviamos al servidor el nombre tecleado
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                    server.Send(msg);
                }
            }
        }

        private void abandonar_Click(object sender, EventArgs e)
        {
            if (!partida)
                MessageBox.Show("No estás dentro de ninguna partida.");
            else
            {
                if (jugando)
                {
                    mensaje = "16/" + idpartida + "/" + username;
                    jugando = false;
                    Jugador1.Text = "Jugador 1";
                    Jugador2.Text = "Jugador 2";
                    Jugador3.Text = "Jugador 3";
                    Jugador4.Text = "Jugador 4";
                    apuesta1.Text = "Cantidad Apostada:";
                    apuesta2.Text = "Cantidad Apostada:";
                    apuesta3.Text = "Cantidad Apostada:";
                    apuesta4.Text = "Cantidad Apostada:";
                    contador = 0;
                    jugando = false;
                    apuesta = false;
                    if (acabado)
                    {
                        acabado = false;
                        this.Invoke(new DelegadoParaFormulario(EmpezarCartas), new object[] { } );
                    }
                }

                else
                    mensaje = "16/" + idpartida;

                msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                Jugador1.Text = "Jugador 1";
                Jugador2.Text = "Jugador 2";
                Jugador3.Text = "Jugador 3";
                Jugador4.Text = "Jugador 4";
                apuesta1.Text = "Cantidad Apostada:";
                apuesta2.Text = "Cantidad Apostada:";
                apuesta3.Text = "Cantidad Apostada:";
                apuesta4.Text = "Cantidad Apostada:";
                server.Send(msg);
            }
        }

        private void reiniciar_Click(object sender, EventArgs e)
        {
            if (!servidor)
                MessageBox.Show("Primero debes conectarte con el servidor.");
            else
            {
                if (!conectado)
                    MessageBox.Show("Debes conectarte con un usuario.");
                else
                {
                    if (!partida)
                        MessageBox.Show("No estás en ninguna partida.");
                    else
                    {
                        if (!acabado)
                            MessageBox.Show("La partida aún no ha terminado.");
                        else
                        {
                            mensaje = "19/" + idpartida + "/" + username;
                            msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                            server.Send(msg);
                            
                            apuesta = false;
                            this.Invoke(new DelegadoParaFormulario(EmpezarCartas), new object[] { });
                            this.Invoke(new DelegadoParaLabels(ActualizarLabels), new object[] { Convert.ToString(5) });
                            acabado = false;
                            contador = 0;
                        }
                    }
                }
            }
        }
    }
}






