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
            var hourtime = hourAux.ToString("HHmm");
            var hourtimeString = hourAux.ToString("HH:mm tt");
            int nowHours = Convert.ToInt32(hourtime);
            Console.WriteLine(nowHours);



            // PREDICTOR

            
            // Monday
            if (day == "Monday")
            {
                if (numberAux == 1 || numberAux == 2)
                {
                    message(nowHours);
                }

                else
                {
                    richTextBox1.Text = "puede Circular";
                }



            }

            // Tuesday
            else if (day == "Tuesday")
            {
                if (numberAux == 3 || numberAux == 4)
                {
                    message(nowHours);

                }

                else
                {
                    richTextBox1.Text = "puede Circular";
                }



            }
            // Wednesday
            else if (day == "Wednesday")
            {
                if (numberAux == 5 || numberAux == 6)
                {
                    message(nowHours);

                }

                else
                {
                    richTextBox1.Text = "puede Circular";
                }



            }
            // Thursday
            else if (day == "Thursday")
            {
                if (numberAux == 7 || numberAux == 8)
                {
                    message(nowHours);

                }

                else
                {
                    richTextBox1.Text = "puede Circular";
                }



            }
            //Friday
            else if (day == "Friday")
            {
                if (numberAux == 9 || numberAux == 0)
                {
                    message(nowHours);

                }

                else
                {
                    Console.WriteLine("puede Circular" );
                }



            }
            //
            else
            {
                richTextBox1.Text = "SI PUEDE CIRCULAR TODO EL DIA EN Su Vehiculo";

            }


        }

        public void message(int hour) 
        {
            if (hour >= 0730 && hour <= 0930)
            {
                richTextBox1.Text = "No puede Circular desde  7:30 a 9:30";


            }

            else if (hour >= 1630 && hour <= 1930)
            {
                richTextBox1.Text = "No puede Circular desde  16:30 a 19:30";


            }

            else
            {
                richTextBox1.Text = "puede Circular";
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mtxtDate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void numbreKeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr!=8)
            {
                e.Handled = true;
                MessageBox.Show("Enter a Valid Value");
            }
        }
    }
}
