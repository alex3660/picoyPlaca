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
            picoPlaca objpicoPlaca = new picoPlaca();
            objpicoPlaca.Number = txtNumber.Text;
            objpicoPlaca.Date = mtxtDate.Text;
            objpicoPlaca.Hour = mtxtHour.Text;

            //call the  method PicoPlacas in the class picoPlaca and set the response of the query
            richTextBox1.Text= objpicoPlaca.PicoPlacas(objpicoPlaca);
                      
            

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
