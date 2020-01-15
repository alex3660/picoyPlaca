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

        public string PicoPlacas(string day, int numberAux, int nowHours)
        {
            string response;
            switch (day)
            {
                case "Monday":
                    if (numberAux == 1 || numberAux == 2)
                    {
                       return message(nowHours);
                    }

                    else
                    {
                        response = "Puede Circular";
                        return response;
                    }

                    
                case "Tuesday":
                    if (numberAux == 3 || numberAux == 4)
                    {
                        return message(nowHours);
                    }

                    else
                    {
                        response = "Puede Circular";
                        return response;
                    }

                    
                case "Wednesday":
                    if (numberAux == 5 || numberAux == 6)
                    {
                       return message(nowHours);
                    }

                    else
                    {
                        response = "Puede Circular";
                        return response;
                    }

                    
                case "Thursday":
                    if (numberAux == 7 || numberAux == 8)
                    {
                       return message(nowHours);
                    }

                    else
                    {
                        response = "Puede Circular";
                        return response;
                    }

                    
                case "Friday":
                    if (numberAux == 9 || numberAux == 0)
                    {
                        return message(nowHours);
                    }

                    else
                    {
                        response = "Puede Circular";
                        return response;
                    }
                    

                case "Saturday":

                    response = "Puede Circular";
                    return response;

                case "Sunday":

                    response = "Puede Circular";
                    return response;

                default:
                    return null;
            }
            

        }

        public string message(int hour)
        {
            string response;
            if (hour >= 0730 && hour <= 0930)
            {
                response= "No puede Circular desde  7:30 a 9:30";
                return response;


            }

            else if (hour >= 1630 && hour <= 1930)
            {
                response = "No puede Circular desde  16:30 a 19:30";
                return response;


            }

            else
            {
                response = "Puede Circular";
                return response;
            }
        }


    }
}
