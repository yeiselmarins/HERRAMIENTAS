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
    public partial class PEDIDO : Form
    {
        public PEDIDO()
        {
            InitializeComponent();
        }

        private void buttonTOTAL_Click(object sender, EventArgs e)
        {
            int poblado = 0;
            int fit = 0;
            int campesinas = 0;
            int lleras = 0;
            int total = 0;
            int cantpoblado = 0;
            int cantfit = 0;
            int cantcampesinas = 0;
            int cantlleras = 0;
            int tolpoblado = 0;
            int tolfit = 0;
            int tolcampesinas = 0;
            int tolleras = 0;

            poblado = Convert.ToInt32(label1.Text);
            fit = Convert.ToInt32(label2.Text);
            campesinas = Convert.ToInt32(label3.Text);
            lleras = Convert.ToInt32(label4.Text);
            cantpoblado = Convert.ToInt32(numericUpDown1.Text);
            cantfit = Convert.ToInt32(numericUpDown2.Text);
            cantcampesinas = Convert.ToInt32(numericUpDown3.Text);
            cantlleras = Convert.ToInt32(numericUpDown4.Text);

            if (checkBox1.Checked == true)
            {
                tolpoblado = poblado * cantpoblado;
            }
            if (checkBox2.Checked == true)
            {
                tolfit = fit * cantfit;
            }
            if (checkBox3.Checked == true)
            {
                tolcampesinas = campesinas * cantcampesinas;
            }
            if (checkBox4.Checked == true)
            {
                tolleras = lleras * cantlleras;
            }
            total = tolpoblado + tolfit + tolleras + tolcampesinas;
            textBox1.Text = total.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
