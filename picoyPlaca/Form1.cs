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
        //Variables
        string day;
        string lastNumber;
        int numberAux;
        
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
          
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Get Information
            picoPlaca picoPlaca = new picoPlaca();
            picoPlaca.Number = txtNumber.Text;
            picoPlaca.Date = mtxtDate.Text;
            picoPlaca.Hour = mtxtHour.Text;

            //Day of the week
            DateTime dateAux = new DateTime();
            dateAux = Convert.ToDateTime(picoPlaca.Date);
            day = dateAux.ToString("dddd");
            Console.WriteLine(day);


            //Number
            lastNumber = picoPlaca.Number.Substring(picoPlaca.Number.Length - 1, 1);
            numberAux = Convert.ToInt32(lastNumber);
            Console.WriteLine(numberAux);

            //Hour
            DateTime hourAux = new DateTime();            
            hourAux = Convert.ToDateTime(picoPlaca.Hour);
            var hourtime = hourAux.ToString("HH:mm");
            Console.WriteLine(hourtime);



            // PREDICTOR
            if ( day == "Saturday" || day == "Sunday")
            {
                richTextBox1.Text = "SI PUEDE CIRCULAR TODO EL DIA";

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
