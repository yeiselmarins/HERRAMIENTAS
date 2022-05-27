using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HERRAMIENTAS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            if (textBoxUsuario.Text == "yeisel" && textBoxContraseña.Text == "0209")
            {
                MessageBox.Show("Bienvenido a la salchipaperia! <3");
                this.Hide();
                MENU NuevaVentana = new MENU();
                NuevaVentana.Show();
            }
            else
            {
                MessageBox.Show("Error por favor intente neuvamente! <3");
                textBoxUsuario.Text = " ";
                textBoxContraseña.Text = "";
                textBoxUsuario.Focus();
            }
        }
    }
}
