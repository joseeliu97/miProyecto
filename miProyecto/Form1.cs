using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miProyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblnum2_Click(object sender, EventArgs e)
        {

        }

        private void btnprocesar_Click(object sender, EventArgs e)
        {
            sbyte num1 = sbyte.Parse(txtnum1.Text);
            sbyte num2 = sbyte.Parse(txtnum2.Text);

            int respuesta = 0;
            if(optSuma.Checked){
                respuesta = num1 + num2;

            }
            if (optResta.Checked)
            {
                respuesta = num1 - num2;

            }
            if (optDivicion.Checked)
            {
                respuesta = num1 / num2;

            }
            if (optMultiplicacion.Checked)
            {
                respuesta = num1 * num2;

            }
            lblrespuesta.Text = "respuesta: " + respuesta;

        }
    }
}
