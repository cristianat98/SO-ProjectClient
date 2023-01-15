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

namespace Cliente
{
    public partial class Apuesta : Form
    {
        Socket server;
        int idpartida;
        public Apuesta(Socket socket, int id_partida)
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            server = socket;
            idpartida = id_partida;
        }

        private void apostar_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(textBox1.Text);
                if (num > 3 && num < 36)
                {
                    string mensaje = "10/" + num + "/" +  + idpartida;
                    // Enviamos al servidor el nombre tecleado
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                    server.Send(msg);
                    this.Close();
                }

                else
                    MessageBox.Show("El número debe estar entre 3 y 36.");
            }

            catch (FormatException)
            {
                MessageBox.Show("Debes introducir un número.");
            }
        }
    }
}
