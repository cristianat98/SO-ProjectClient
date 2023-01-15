using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;

namespace Cliente
{
    public partial class Registro : Form
    {

        private Socket socket;

        public Registro(Socket socket)
        {
            InitializeComponent();
            this.socket = socket;
        }

        private void Registro_FormClosing(object sender, FormClosingEventArgs e)
        {
            nombre.Clear();
            contraseña.Clear();
        }
        
        private void crear_usuario_Click(object sender, EventArgs e)
        {
            if (nombre.Text == "" || contraseña.Text == "" || contraseña1.Text == "")
                MessageBox.Show("No se han introducido todos los datos.");

            else 
            {
                if (contraseña.Text == contraseña1.Text)
                {
                    string mensaje = "1/" + nombre.Text + "/" + contraseña.Text;
                    // Enviamos al servidor el nombre tecleado
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                    socket.Send(msg);
                    this.Close();
                }

                else
                    MessageBox.Show("Las contraseñas son distintas.");
            }         
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            nombre.Clear();
            contraseña.Clear();
            this.Close();
        }
    }
}
