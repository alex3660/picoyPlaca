using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace picoyPlaca
{
    class picoPlaca
    {
        
        private string fecha;
        private string numeroplaca;
        private string hora;

        
        public string Fecha { get => fecha; set => fecha = value; }
        public string Numeroplaca { get => numeroplaca; set => numeroplaca = value; }
        public string Hora { get => hora; set => hora = value; }
        
        public picoPlaca()
        {

        }
        public picoPlaca(string fecha, string numeroplaca, string hora)
        {
            this.fecha = fecha;
            this.numeroplaca = numeroplaca;
            this.hora = hora;
        }

    }
}
