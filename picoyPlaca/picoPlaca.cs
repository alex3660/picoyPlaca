using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace picoyPlaca
{
    class picoPlaca
    {
        
        private string date;
        private string number;
        private string hour;

        //Get and set
        public string Date { get => date; set => date = value; }
        public string Number { get => number; set => number = value; }
        public string Hour { get => hour; set => hour = value; }


        // Constructors
        public picoPlaca()
        {

        }
        public picoPlaca(string date, string number, string hour)
        {
            this.date = date;
            this.number = number;
            this.hour = hour;
        }

        
    }
}
