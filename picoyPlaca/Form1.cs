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
            // Get Form's Information
            richTextBox1.Text = "";
            picoPlaca picoPlaca = new picoPlaca();
            picoPlaca.Number = txtNumber.Text;
            picoPlaca.Date = mtxtDate.Text;
            picoPlaca.Hour = mtxtHour.Text;

            // Get the day of the week in string and catch the excepcion if the format of the date is incorrect
            try
            {
                DateTime dateAux = new DateTime();
                dateAux = Convert.ToDateTime(picoPlaca.Date);
                day = dateAux.ToString("dddd");
                
            }
            catch (FormatException err)
            {
                MessageBox.Show("Enter a Valid Date");
                
            }

            //get the last Number of the licence and catch the excepcion if yo dont set a number
            try
            {
                lastNumber = picoPlaca.Number.Substring(picoPlaca.Number.Length - 1, 1);
                numberAux = Convert.ToInt32(lastNumber);
                
            }
            catch (ArgumentOutOfRangeException err)
            {
                MessageBox.Show("Enter a Valid Number");
                
            }


            // get the Hour in format that can be compare as a int
            try
            {
                DateTime hourAux = new DateTime();
                hourAux = Convert.ToDateTime(picoPlaca.Hour);
                var hourtime = hourAux.ToString("HHmm");
                nowHours = Convert.ToInt32(hourtime);
                

                
            }
            catch (FormatException err)
            {
                MessageBox.Show("Enter a Valid Hour");
                
            }



            //call the  method PicoPlacas in the class picoPlaca and set the response of the query
            richTextBox1.Text= picoPlaca.PicoPlacas(day, numberAux, nowHours);
                      
            

        }           
        //this method is using to use only numbers and backspace
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
