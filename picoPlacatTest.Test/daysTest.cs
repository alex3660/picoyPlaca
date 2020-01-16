using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using picoyPlaca;


namespace picoPlacatTest.Test
{
    [TestClass]
    public class daysTest
    {
        [TestMethod]
        public void noAviableOnMondayintheMonrning()
        {
            string date = "01/13/2020";
            string number = "1111";
            string hour = "08:30";
             string expected = "No aviable to be on the road from  7:30 to 9:30";

            picoPlaca obj = new picoPlaca();
            obj.Date = date;
            obj.Number = number;
            obj.Hour = hour;

            string result = obj.PicoPlacas(obj);

            Assert.AreEqual(expected, result);


        }
    }
}
