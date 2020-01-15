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

        //this method verify the date number of license to be aviable to be on the road
        public string PicoPlacas(string day, int numberAux, int nowHours)
        {
            
            switch (day)
            {
                case "Monday":
                    if (numberAux == 1 || numberAux == 2)
                    {
                       return message(nowHours);
                    }

                    else
                    {
                        return aviableorNot(2);
                    }

                    
                case "Tuesday":
                    if (numberAux == 3 || numberAux == 4)
                    {
                        return message(nowHours);
                    }

                    else
                    {
                        return aviableorNot(2);
                    }

                    
                case "Wednesday":
                    if (numberAux == 5 || numberAux == 6)
                    {
                       return message(nowHours);
                    }

                    else
                    {
                        return aviableorNot(2);
                    }

                    
                case "Thursday":
                    if (numberAux == 7 || numberAux == 8)
                    {
                       return message(nowHours);
                    }

                    else
                    {
                        return aviableorNot(2);
                    }

                    
                case "Friday":
                    if (numberAux == 9 || numberAux == 0)
                    {
                        return message(nowHours);
                    }

                    else
                    {
                        return aviableorNot(2);
                    }
                    

                case "Saturday":

                    return aviableorNot(2);

                case "Sunday":

                    return aviableorNot(2);

                default:
                    return null;
            }
            

        }

        //this method verify the hours to aply pico y placa
        public string message(int hour)
        {
            
            if (hour >= 0730 && hour <= 0930)
            {               
                return aviableorNot(0);
            }

            else if (hour >= 1630 && hour <= 1930)
            {                
                return aviableorNot(1);            
            }


            else
            {                
                return aviableorNot(2);
            }
        }


        //this method return the message if you are aviable or not to be on the road

        public  string aviableorNot (int value)
        {
            string response;
            if (value == 0)
            {
                response = "No aviable to be on the road from  7:30 to 9:30";
                return response;

            }

            else if (value == 1)
            {
                response = "No aviable to be on the road from  16:30 to 19:30";
                return response;


            }


            else
            {
                response = "Aviable to be on the road";
                return response;
            }
        }

        


    }
}
