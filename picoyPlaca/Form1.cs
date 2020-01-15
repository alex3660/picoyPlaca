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
        int nowHours;

        public Form1()
        {
            InitializeComponent();
        }

       

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Get Information
            richTextBox1.Text = "";
            picoPlaca picoPlaca = new picoPlaca();
            picoPlaca.Number = txtNumber.Text;
            picoPlaca.Date = mtxtDate.Text;
            picoPlaca.Hour = mtxtHour.Text;

            //Day of the week
            try
            {
                DateTime dateAux = new DateTime();
                dateAux = Convert.ToDateTime(picoPlaca.Date);
                day = dateAux.ToString("dddd");
                
            }
            catch (FormatException err)
            {
                MessageBox.Show("Enter a Valid Date");
                richTextBox1.Text = "";
            }



            //Number
            try
            {
                lastNumber = picoPlaca.Number.Substring(picoPlaca.Number.Length - 1, 1);
                numberAux = Convert.ToInt32(lastNumber);
                
            }
            catch (ArgumentOutOfRangeException err)
            {
                MessageBox.Show("Enter a Valid Number");
                richTextBox1.Text = "";
            }


            //Hour
            try
            {
                DateTime hourAux = new DateTime();
                hourAux = Convert.ToDateTime(picoPlaca.Hour);
                var hourtime = hourAux.ToString("HHmm");
                var hourtimeString = hourAux.ToString("HH:mm tt");
                nowHours = Convert.ToInt32(hourtime);
                
            }
            catch (FormatException err)
            {
                MessageBox.Show("Enter a Valid Hour");
                richTextBox1.Text = "";
            }



            // PREDICTOR
            picoPlacas(day, numberAux, nowHours);
                      


        }

        
        public void picoPlacas(string day, int numberAux, int nowHours)
        {
            switch (day)
            {
                case "Monday":
                    if (numberAux == 1 || numberAux == 2)
                    {
                        message(nowHours);
                    }

                    else
                    {
                        richTextBox1.Text = "Puede Circular";
                    }

                    break;
                case "Tuesday":
                    if (numberAux == 3 || numberAux == 4)
                    {
                        message(nowHours);
                    }

                    else
                    {
                        richTextBox1.Text = "Puede Circular";
                    }

                    break;
                case "Wednesday":
                    if (numberAux == 5 || numberAux == 6)
                    {
                        message(nowHours);
                    }

                    else
                    {
                        richTextBox1.Text = "Puede Circular";
                    }

                    break;
                case "Thursday":
                    if (numberAux == 7 || numberAux == 8)
                    {
                        message(nowHours);
                    }

                    else
                    {
                        richTextBox1.Text = "Puede Circular";
                    }

                    break;
                case "Friday":
                    if (numberAux == 9 || numberAux == 0)
                    {
                        message(nowHours);
                    }

                    else
                    {
                        richTextBox1.Text = "Puede Circular";
                    }
                    break;

                case "Saturday":

                    richTextBox1.Text = "Puede Circular";
                    break;

                case "Sunday":

                    richTextBox1.Text = "Puede Circular";

                    break;
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
                richTextBox1.Text = "Puede Circular";
            }
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
