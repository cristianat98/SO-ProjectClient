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

namespace Cliente
{
    public partial class Aceptar : Form
    {
        Socket server;
        int id_partida;
        string inv;
        bool aceptar = false;

        public Aceptar(Socket server, string mensaje)
        {
            InitializeComponent();
            this.server = server;
            id_partida = Convert.ToInt32(mensaje.Split('/')[1]);
            inv = mensaje.Split('/')[0];
            label1.Text = mensaje.Split('/')[0] + " te ha invitado a jugar una partida.";
        }

        private void aceptarPartida_Click(object sender, EventArgs e)
        {
            // Acepta jugar
            string mensaje = "15/" + id_partida + "/" + inv + "/1";
            // Enviamos al servidor el nombre tecleado
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
            aceptar = true;
            this.Close();
        }

        private void rechazarPartida_Click(object sender, EventArgs e)
        {
            // No acepta jugar
            string mensaje = "15/" + id_partida + "/" + inv + "/0";
            // Enviamos al servidor el nombre tecleado
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
            aceptar = true;
            this.Close();
        }

        private void Aceptar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!aceptar)
            {
                string mensaje = "15/" + id_partida + "/" + inv + "/0";
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);
            }
        }
    }
}
