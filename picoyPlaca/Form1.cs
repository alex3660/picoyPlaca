using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace picoyPlaca
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            picoPlaca picoPlaca = new picoPlaca();
            picoPlaca.Numeroplaca = txtNumeroPlaca.Text;
            picoPlaca.Fecha = mtxtFecha.Text;
            picoPlaca.Hora = mtxtHora.Text;

            DateTime fechaAux = new DateTime();
            fechaAux = Convert.ToDateTime(picoPlaca.Fecha);
            Console.WriteLine(fechaAux);

            
        }
    }
}
