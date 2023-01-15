namespace Cliente
{
    partial class Conexion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
            
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conexion));
            this.conectar = new System.Windows.Forms.Button();
            this.desconectar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inicia_sesion = new System.Windows.Forms.Button();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Registro = new System.Windows.Forms.Button();
            this.nombre = new System.Windows.Forms.TextBox();
            this.mejor_jugador = new System.Windows.Forms.Button();
            this.partida_larga = new System.Windows.Forms.Button();
            this.peor_jugador = new System.Windows.Forms.Button();
            this.partida_corta = new System.Windows.Forms.Button();
            this.listaConectados = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.invitar = new System.Windows.Forms.Button();
            this.Chatgrande = new System.Windows.Forms.TextBox();
            this.Chatpequeno = new System.Windows.Forms.TextBox();
            this.EnviarChat = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Baja = new System.Windows.Forms.Button();
            this.apuesta4 = new System.Windows.Forms.Label();
            this.apuesta3 = new System.Windows.Forms.Label();
            this.apuesta2 = new System.Windows.Forms.Label();
            this.apuesta1 = new System.Windows.Forms.Label();
            this.inicio = new System.Windows.Forms.Button();
            this.Jugador4 = new System.Windows.Forms.Label();
            this.Jugador3 = new System.Windows.Forms.Label();
            this.Jugador2 = new System.Windows.Forms.Label();
            this.Jugador1 = new System.Windows.Forms.Label();
            this.reglas_juego = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iniciojuego = new System.Windows.Forms.Button();
            this.abandonar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Izq1 = new System.Windows.Forms.Button();
            this.Centro1 = new System.Windows.Forms.Button();
            this.Der1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Der2 = new System.Windows.Forms.Button();
            this.Centro2 = new System.Windows.Forms.Button();
            this.Izq2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Centro3 = new System.Windows.Forms.Button();
            this.Izq3 = new System.Windows.Forms.Button();
            this.Der3 = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.Der4 = new System.Windows.Forms.Button();
            this.Centro4 = new System.Windows.Forms.Button();
            this.Izq4 = new System.Windows.Forms.Button();
            this.reiniciar = new System.Windows.Forms.Button();
            this.puntuacion1 = new System.Windows.Forms.Label();
            this.puntuacion4 = new System.Windows.Forms.Label();
            this.puntuacion3 = new System.Windows.Forms.Label();
            this.puntuacion2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaConectados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // conectar
            // 
            this.conectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.conectar.Location = new System.Drawing.Point(12, 12);
            this.conectar.Name = "conectar";
            this.conectar.Size = new System.Drawing.Size(83, 33);
            this.conectar.TabIndex = 0;
            this.conectar.Text = "Conectar";
            this.conectar.UseVisualStyleBackColor = true;
            this.conectar.Click += new System.EventHandler(this.conectar_Click);
            // 
            // desconectar
            // 
            this.desconectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.desconectar.Location = new System.Drawing.Point(101, 6);
            this.desconectar.Name = "desconectar";
            this.desconectar.Size = new System.Drawing.Size(114, 47);
            this.desconectar.TabIndex = 1;
            this.desconectar.Text = "Desconectar Usuario";
            this.desconectar.UseVisualStyleBackColor = true;
            this.desconectar.Click += new System.EventHandler(this.desconectar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.inicia_sesion);
            this.groupBox1.Controls.Add(this.contraseña);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Registro);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 139);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peticion";
            // 
            // inicia_sesion
            // 
            this.inicia_sesion.Location = new System.Drawing.Point(202, 100);
            this.inicia_sesion.Name = "inicia_sesion";
            this.inicia_sesion.Size = new System.Drawing.Size(89, 23);
            this.inicia_sesion.TabIndex = 8;
            this.inicia_sesion.Text = "Iniciar Sesión ";
            this.inicia_sesion.UseVisualStyleBackColor = true;
            this.inicia_sesion.Click += new System.EventHandler(this.inicia_sesion_Click);
            // 
            // contraseña
            // 
            this.contraseña.Location = new System.Drawing.Point(148, 74);
            this.contraseña.Name = "contraseña";
            this.contraseña.PasswordChar = '*';
            this.contraseña.Size = new System.Drawing.Size(164, 20);
            this.contraseña.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario";
            // 
            // Registro
            // 
            this.Registro.Location = new System.Drawing.Point(44, 100);
            this.Registro.Name = "Registro";
            this.Registro.Size = new System.Drawing.Size(89, 23);
            this.Registro.TabIndex = 5;
            this.Registro.Text = "Crear Usuario";
            this.Registro.UseVisualStyleBackColor = true;
            this.Registro.Click += new System.EventHandler(this.Registro_Click_1);
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(148, 30);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(164, 20);
            this.nombre.TabIndex = 3;
            // 
            // mejor_jugador
            // 
            this.mejor_jugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mejor_jugador.Location = new System.Drawing.Point(374, 65);
            this.mejor_jugador.Name = "mejor_jugador";
            this.mejor_jugador.Size = new System.Drawing.Size(135, 27);
            this.mejor_jugador.TabIndex = 16;
            this.mejor_jugador.Text = "Mejor Jugador";
            this.mejor_jugador.UseVisualStyleBackColor = true;
            this.mejor_jugador.Click += new System.EventHandler(this.mejor_jugador_Click);
            // 
            // partida_larga
            // 
            this.partida_larga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.partida_larga.Location = new System.Drawing.Point(349, 129);
            this.partida_larga.Name = "partida_larga";
            this.partida_larga.Size = new System.Drawing.Size(160, 29);
            this.partida_larga.TabIndex = 15;
            this.partida_larga.Text = "Partida más larga";
            this.partida_larga.UseVisualStyleBackColor = true;
            this.partida_larga.Click += new System.EventHandler(this.partida_larga_Click);
            // 
            // peor_jugador
            // 
            this.peor_jugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.peor_jugador.Location = new System.Drawing.Point(374, 98);
            this.peor_jugador.Name = "peor_jugador";
            this.peor_jugador.Size = new System.Drawing.Size(135, 25);
            this.peor_jugador.TabIndex = 14;
            this.peor_jugador.Text = "Peor jugador";
            this.peor_jugador.UseVisualStyleBackColor = true;
            this.peor_jugador.Click += new System.EventHandler(this.peor_jugador_Click);
            // 
            // partida_corta
            // 
            this.partida_corta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.partida_corta.Location = new System.Drawing.Point(349, 164);
            this.partida_corta.Name = "partida_corta";
            this.partida_corta.Size = new System.Drawing.Size(160, 29);
            this.partida_corta.TabIndex = 17;
            this.partida_corta.Text = "Partida más corta";
            this.partida_corta.UseVisualStyleBackColor = true;
            this.partida_corta.Click += new System.EventHandler(this.partida_corta_Click);
            // 
            // listaConectados
            // 
            this.listaConectados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaConectados.Location = new System.Drawing.Point(12, 231);
            this.listaConectados.Name = "listaConectados";
            this.listaConectados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaConectados.Size = new System.Drawing.Size(161, 157);
            this.listaConectados.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "LISTA DE CONECTADOS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(346, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Ahora estás conectado como:";
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Location = new System.Drawing.Point(371, 32);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(93, 13);
            this.user.TabIndex = 41;
            this.user.Text = "NO CONECTADO";
            // 
            // invitar
            // 
            this.invitar.Location = new System.Drawing.Point(42, 403);
            this.invitar.Name = "invitar";
            this.invitar.Size = new System.Drawing.Size(79, 24);
            this.invitar.TabIndex = 42;
            this.invitar.Text = "Invitar";
            this.invitar.UseVisualStyleBackColor = true;
            this.invitar.Click += new System.EventHandler(this.invitar_Click);
            // 
            // Chatgrande
            // 
            this.Chatgrande.Location = new System.Drawing.Point(179, 231);
            this.Chatgrande.Multiline = true;
            this.Chatgrande.Name = "Chatgrande";
            this.Chatgrande.Size = new System.Drawing.Size(224, 157);
            this.Chatgrande.TabIndex = 49;
            // 
            // Chatpequeno
            // 
            this.Chatpequeno.Location = new System.Drawing.Point(179, 407);
            this.Chatpequeno.Name = "Chatpequeno";
            this.Chatpequeno.Size = new System.Drawing.Size(176, 20);
            this.Chatpequeno.TabIndex = 48;
            // 
            // EnviarChat
            // 
            this.EnviarChat.Location = new System.Drawing.Point(361, 403);
            this.EnviarChat.Name = "EnviarChat";
            this.EnviarChat.Size = new System.Drawing.Size(90, 22);
            this.EnviarChat.TabIndex = 46;
            this.EnviarChat.Text = "Enviar Mensaje";
            this.EnviarChat.UseVisualStyleBackColor = true;
            this.EnviarChat.Click += new System.EventHandler(this.EnviarChat_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(295, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Chat";
            // 
            // Baja
            // 
            this.Baja.BackColor = System.Drawing.Color.Transparent;
            this.Baja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Baja.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Baja.Location = new System.Drawing.Point(220, 9);
            this.Baja.Margin = new System.Windows.Forms.Padding(2);
            this.Baja.Name = "Baja";
            this.Baja.Size = new System.Drawing.Size(82, 41);
            this.Baja.TabIndex = 66;
            this.Baja.Text = "Darse de Baja";
            this.Baja.UseVisualStyleBackColor = false;
            this.Baja.Click += new System.EventHandler(this.Baja_Click);
            // 
            // apuesta4
            // 
            this.apuesta4.AutoSize = true;
            this.apuesta4.Location = new System.Drawing.Point(947, 342);
            this.apuesta4.Name = "apuesta4";
            this.apuesta4.Size = new System.Drawing.Size(100, 13);
            this.apuesta4.TabIndex = 90;
            this.apuesta4.Text = "Cantidad Apostada:";
            // 
            // apuesta3
            // 
            this.apuesta3.AutoSize = true;
            this.apuesta3.Location = new System.Drawing.Point(615, 342);
            this.apuesta3.Name = "apuesta3";
            this.apuesta3.Size = new System.Drawing.Size(100, 13);
            this.apuesta3.TabIndex = 89;
            this.apuesta3.Text = "Cantidad Apostada:";
            // 
            // apuesta2
            // 
            this.apuesta2.AutoSize = true;
            this.apuesta2.Location = new System.Drawing.Point(1006, 172);
            this.apuesta2.Name = "apuesta2";
            this.apuesta2.Size = new System.Drawing.Size(100, 13);
            this.apuesta2.TabIndex = 88;
            this.apuesta2.Text = "Cantidad Apostada:";
            // 
            // apuesta1
            // 
            this.apuesta1.AutoSize = true;
            this.apuesta1.Location = new System.Drawing.Point(629, 172);
            this.apuesta1.Name = "apuesta1";
            this.apuesta1.Size = new System.Drawing.Size(100, 13);
            this.apuesta1.TabIndex = 87;
            this.apuesta1.Text = "Cantidad Apostada:";
            // 
            // inicio
            // 
            this.inicio.Location = new System.Drawing.Point(1442, 49);
            this.inicio.Name = "inicio";
            this.inicio.Size = new System.Drawing.Size(134, 29);
            this.inicio.TabIndex = 86;
            this.inicio.Text = "A JUGAR!";
            this.inicio.UseVisualStyleBackColor = true;
            // 
            // Jugador4
            // 
            this.Jugador4.AutoSize = true;
            this.Jugador4.Location = new System.Drawing.Point(867, 342);
            this.Jugador4.Name = "Jugador4";
            this.Jugador4.Size = new System.Drawing.Size(54, 13);
            this.Jugador4.TabIndex = 84;
            this.Jugador4.Text = "Jugador 4";
            // 
            // Jugador3
            // 
            this.Jugador3.AutoSize = true;
            this.Jugador3.Location = new System.Drawing.Point(539, 342);
            this.Jugador3.Name = "Jugador3";
            this.Jugador3.Size = new System.Drawing.Size(54, 13);
            this.Jugador3.TabIndex = 83;
            this.Jugador3.Text = "Jugador 3";
            // 
            // Jugador2
            // 
            this.Jugador2.AutoSize = true;
            this.Jugador2.Location = new System.Drawing.Point(931, 172);
            this.Jugador2.Name = "Jugador2";
            this.Jugador2.Size = new System.Drawing.Size(54, 13);
            this.Jugador2.TabIndex = 82;
            this.Jugador2.Text = "Jugador 2";
            // 
            // Jugador1
            // 
            this.Jugador1.AutoSize = true;
            this.Jugador1.Location = new System.Drawing.Point(563, 172);
            this.Jugador1.Name = "Jugador1";
            this.Jugador1.Size = new System.Drawing.Size(54, 13);
            this.Jugador1.TabIndex = 81;
            this.Jugador1.Text = "Jugador 1";
            // 
            // reglas_juego
            // 
            this.reglas_juego.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.reglas_juego.Location = new System.Drawing.Point(1442, 19);
            this.reglas_juego.Name = "reglas_juego";
            this.reglas_juego.Size = new System.Drawing.Size(134, 24);
            this.reglas_juego.TabIndex = 80;
            this.reglas_juego.Text = "Reglas del Juego";
            this.reglas_juego.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1370, 534);
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            // 
            // iniciojuego
            // 
            this.iniciojuego.Location = new System.Drawing.Point(1209, 16);
            this.iniciojuego.Name = "iniciojuego";
            this.iniciojuego.Size = new System.Drawing.Size(134, 29);
            this.iniciojuego.TabIndex = 92;
            this.iniciojuego.Text = "A JUGAR!";
            this.iniciojuego.UseVisualStyleBackColor = true;
            this.iniciojuego.Click += new System.EventHandler(this.iniciojuego_Click);
            // 
            // abandonar
            // 
            this.abandonar.Location = new System.Drawing.Point(1209, 57);
            this.abandonar.Name = "abandonar";
            this.abandonar.Size = new System.Drawing.Size(134, 29);
            this.abandonar.TabIndex = 93;
            this.abandonar.Text = "Abandonar Partida";
            this.abandonar.UseVisualStyleBackColor = true;
            this.abandonar.Click += new System.EventHandler(this.abandonar_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.46939F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.53061F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel1.Controls.Add(this.Izq1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Centro1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Der1, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(539, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(300, 140);
            this.tableLayoutPanel1.TabIndex = 94;
            // 
            // Izq1
            // 
            this.Izq1.Image = ((System.Drawing.Image)(resources.GetObject("Izq1.Image")));
            this.Izq1.Location = new System.Drawing.Point(3, 3);
            this.Izq1.Name = "Izq1";
            this.Izq1.Size = new System.Drawing.Size(89, 134);
            this.Izq1.TabIndex = 69;
            this.Izq1.UseVisualStyleBackColor = true;
            // 
            // Centro1
            // 
            this.Centro1.Image = ((System.Drawing.Image)(resources.GetObject("Centro1.Image")));
            this.Centro1.Location = new System.Drawing.Point(98, 3);
            this.Centro1.Name = "Centro1";
            this.Centro1.Size = new System.Drawing.Size(94, 134);
            this.Centro1.TabIndex = 70;
            this.Centro1.UseVisualStyleBackColor = true;
            // 
            // Der1
            // 
            this.Der1.Image = ((System.Drawing.Image)(resources.GetObject("Der1.Image")));
            this.Der1.Location = new System.Drawing.Point(198, 3);
            this.Der1.Name = "Der1";
            this.Der1.Size = new System.Drawing.Size(95, 134);
            this.Der1.TabIndex = 71;
            this.Der1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.26109F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.73891F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel2.Controls.Add(this.Der2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Centro2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Izq2, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(867, 18);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(300, 140);
            this.tableLayoutPanel2.TabIndex = 95;
            // 
            // Der2
            // 
            this.Der2.Image = ((System.Drawing.Image)(resources.GetObject("Der2.Image")));
            this.Der2.Location = new System.Drawing.Point(205, 3);
            this.Der2.Name = "Der2";
            this.Der2.Size = new System.Drawing.Size(91, 134);
            this.Der2.TabIndex = 74;
            this.Der2.UseVisualStyleBackColor = true;
            // 
            // Centro2
            // 
            this.Centro2.Image = ((System.Drawing.Image)(resources.GetObject("Centro2.Image")));
            this.Centro2.Location = new System.Drawing.Point(103, 3);
            this.Centro2.Name = "Centro2";
            this.Centro2.Size = new System.Drawing.Size(95, 134);
            this.Centro2.TabIndex = 73;
            this.Centro2.UseVisualStyleBackColor = true;
            // 
            // Izq2
            // 
            this.Izq2.Image = ((System.Drawing.Image)(resources.GetObject("Izq2.Image")));
            this.Izq2.Location = new System.Drawing.Point(3, 3);
            this.Izq2.Name = "Izq2";
            this.Izq2.Size = new System.Drawing.Size(94, 134);
            this.Izq2.TabIndex = 72;
            this.Izq2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.Controls.Add(this.Centro3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.Izq3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.Der3, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(489, 360);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(300, 140);
            this.tableLayoutPanel3.TabIndex = 96;
            // 
            // Centro3
            // 
            this.Centro3.Image = ((System.Drawing.Image)(resources.GetObject("Centro3.Image")));
            this.Centro3.Location = new System.Drawing.Point(104, 3);
            this.Centro3.Name = "Centro3";
            this.Centro3.Size = new System.Drawing.Size(93, 134);
            this.Centro3.TabIndex = 76;
            this.Centro3.UseVisualStyleBackColor = true;
            // 
            // Izq3
            // 
            this.Izq3.Image = ((System.Drawing.Image)(resources.GetObject("Izq3.Image")));
            this.Izq3.Location = new System.Drawing.Point(3, 3);
            this.Izq3.Name = "Izq3";
            this.Izq3.Size = new System.Drawing.Size(95, 134);
            this.Izq3.TabIndex = 75;
            this.Izq3.UseVisualStyleBackColor = true;
            // 
            // Der3
            // 
            this.Der3.Image = ((System.Drawing.Image)(resources.GetObject("Der3.Image")));
            this.Der3.Location = new System.Drawing.Point(203, 3);
            this.Der3.Name = "Der3";
            this.Der3.Size = new System.Drawing.Size(94, 134);
            this.Der3.TabIndex = 77;
            this.Der3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.25641F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.74359F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel4.Controls.Add(this.Der4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.Centro4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.Izq4, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(823, 358);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(300, 140);
            this.tableLayoutPanel4.TabIndex = 97;
            // 
            // Der4
            // 
            this.Der4.Image = ((System.Drawing.Image)(resources.GetObject("Der4.Image")));
            this.Der4.Location = new System.Drawing.Point(197, 3);
            this.Der4.Name = "Der4";
            this.Der4.Size = new System.Drawing.Size(95, 134);
            this.Der4.TabIndex = 80;
            this.Der4.UseVisualStyleBackColor = true;
            // 
            // Centro4
            // 
            this.Centro4.Image = ((System.Drawing.Image)(resources.GetObject("Centro4.Image")));
            this.Centro4.Location = new System.Drawing.Point(100, 3);
            this.Centro4.Name = "Centro4";
            this.Centro4.Size = new System.Drawing.Size(91, 134);
            this.Centro4.TabIndex = 79;
            this.Centro4.UseVisualStyleBackColor = true;
            // 
            // Izq4
            // 
            this.Izq4.Image = ((System.Drawing.Image)(resources.GetObject("Izq4.Image")));
            this.Izq4.Location = new System.Drawing.Point(3, 3);
            this.Izq4.Name = "Izq4";
            this.Izq4.Size = new System.Drawing.Size(91, 134);
            this.Izq4.TabIndex = 78;
            this.Izq4.UseVisualStyleBackColor = true;
            // 
            // reiniciar
            // 
            this.reiniciar.Location = new System.Drawing.Point(1209, 100);
            this.reiniciar.Name = "reiniciar";
            this.reiniciar.Size = new System.Drawing.Size(134, 33);
            this.reiniciar.TabIndex = 100;
            this.reiniciar.Text = "Reiniciar";
            this.reiniciar.UseVisualStyleBackColor = true;
            this.reiniciar.Click += new System.EventHandler(this.reiniciar_Click);
            // 
            // puntuacion1
            // 
            this.puntuacion1.AutoSize = true;
            this.puntuacion1.Location = new System.Drawing.Point(590, 205);
            this.puntuacion1.Name = "puntuacion1";
            this.puntuacion1.Size = new System.Drawing.Size(67, 13);
            this.puntuacion1.TabIndex = 101;
            this.puntuacion1.Text = "Puntuacion: ";
            // 
            // puntuacion4
            // 
            this.puntuacion4.AutoSize = true;
            this.puntuacion4.Location = new System.Drawing.Point(897, 313);
            this.puntuacion4.Name = "puntuacion4";
            this.puntuacion4.Size = new System.Drawing.Size(67, 13);
            this.puntuacion4.TabIndex = 102;
            this.puntuacion4.Text = "Puntuacion: ";
            // 
            // puntuacion3
            // 
            this.puntuacion3.AutoSize = true;
            this.puntuacion3.Location = new System.Drawing.Point(564, 313);
            this.puntuacion3.Name = "puntuacion3";
            this.puntuacion3.Size = new System.Drawing.Size(67, 13);
            this.puntuacion3.TabIndex = 103;
            this.puntuacion3.Text = "Puntuacion: ";
            // 
            // puntuacion2
            // 
            this.puntuacion2.AutoSize = true;
            this.puntuacion2.Location = new System.Drawing.Point(947, 205);
            this.puntuacion2.Name = "puntuacion2";
            this.puntuacion2.Size = new System.Drawing.Size(67, 13);
            this.puntuacion2.TabIndex = 104;
            this.puntuacion2.Text = "Puntuacion: ";
            // 
            // Conexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 542);
            this.Controls.Add(this.puntuacion2);
            this.Controls.Add(this.puntuacion3);
            this.Controls.Add(this.puntuacion4);
            this.Controls.Add(this.puntuacion1);
            this.Controls.Add(this.reiniciar);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.abandonar);
            this.Controls.Add(this.iniciojuego);
            this.Controls.Add(this.apuesta4);
            this.Controls.Add(this.apuesta3);
            this.Controls.Add(this.apuesta2);
            this.Controls.Add(this.apuesta1);
            this.Controls.Add(this.inicio);
            this.Controls.Add(this.Jugador4);
            this.Controls.Add(this.Jugador3);
            this.Controls.Add(this.Jugador2);
            this.Controls.Add(this.Jugador1);
            this.Controls.Add(this.reglas_juego);
            this.Controls.Add(this.Baja);
            this.Controls.Add(this.Chatgrande);
            this.Controls.Add(this.Chatpequeno);
            this.Controls.Add(this.EnviarChat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.invitar);
            this.Controls.Add(this.user);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listaConectados);
            this.Controls.Add(this.partida_corta);
            this.Controls.Add(this.mejor_jugador);
            this.Controls.Add(this.partida_larga);
            this.Controls.Add(this.peor_jugador);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.desconectar);
            this.Controls.Add(this.conectar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Conexion";
            this.Text = "Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaConectados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button conectar;
        private System.Windows.Forms.Button desconectar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button inicia_sesion;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Registro;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Button mejor_jugador;
        private System.Windows.Forms.Button partida_larga;
        private System.Windows.Forms.Button peor_jugador;
        private System.Windows.Forms.Button partida_corta;
        private System.Windows.Forms.DataGridView listaConectados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Button invitar;
        private System.Windows.Forms.TextBox Chatgrande;
        private System.Windows.Forms.TextBox Chatpequeno;
        private System.Windows.Forms.Button EnviarChat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Baja;
        private System.Windows.Forms.Label apuesta4;
        private System.Windows.Forms.Label apuesta3;
        private System.Windows.Forms.Label apuesta2;
        private System.Windows.Forms.Label apuesta1;
        private System.Windows.Forms.Button inicio;
        private System.Windows.Forms.Label Jugador4;
        private System.Windows.Forms.Label Jugador3;
        private System.Windows.Forms.Label Jugador2;
        private System.Windows.Forms.Label Jugador1;
        private System.Windows.Forms.Button reglas_juego;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button iniciojuego;
        private System.Windows.Forms.Button abandonar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Izq1;
        private System.Windows.Forms.Button Centro1;
        private System.Windows.Forms.Button Der1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button Der2;
        private System.Windows.Forms.Button Centro2;
        private System.Windows.Forms.Button Izq2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button Centro3;
        private System.Windows.Forms.Button Izq3;
        private System.Windows.Forms.Button Der3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button Der4;
        private System.Windows.Forms.Button Centro4;
        private System.Windows.Forms.Button Izq4;
        private System.Windows.Forms.Button reiniciar;
        private System.Windows.Forms.Label puntuacion1;
        private System.Windows.Forms.Label puntuacion4;
        private System.Windows.Forms.Label puntuacion3;
        private System.Windows.Forms.Label puntuacion2;
    }
}

