﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using picoyPlaca;

namespace picoYPacaTest.Test
{
    [TestClass]
    public class picoTest
    {
        [TestMethod]
        public void noAviableintheMonrning()
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

        [TestMethod]
        public void noAviableintheAfternoon()
        {
            string date = "01/13/2020";
            string number = "1111";
            string hour = "18:30";
            string expected = "No aviable to be on the road from  16:30 to 19:30";

            picoPlaca obj = new picoPlaca();
            obj.Date = date;
            obj.Number = number;
            obj.Hour = hour;

            string result = obj.PicoPlacas(obj);

            Assert.AreEqual(expected, result);


        }

        [TestMethod]
        public void AviableintheAftenoon()
        {
            string date = "01/13/2020";
            string number = "1111";
            string hour = "12:30";
            string expected = "Aviable to be on the road";

            picoPlaca obj = new picoPlaca();
            obj.Date = date;
            obj.Number = number;
            obj.Hour = hour;

            string result = obj.PicoPlacas(obj);

            Assert.AreEqual(expected, result);


        }

        [TestMethod]
        public void AviableintheNigth()
        {
            string date = "01/13/2020";
            string number = "1111";
            string hour = "21:30";
            string expected = "Aviable to be on the road";

            picoPlaca obj = new picoPlaca();
            obj.Date = date;
            obj.Number = number;
            obj.Hour = hour;

            string result = obj.PicoPlacas(obj);

            Assert.AreEqual(expected, result);


        }

        [TestMethod]
        public void AviableonWeekend()
        {
            string date = "01/18/2020";
            string number = "1111";
            string hour = "21:30";
            string expected = "Aviable to be on the road";

            picoPlaca obj = new picoPlaca();
            obj.Date = date;
            obj.Number = number;
            obj.Hour = hour;

            string result = obj.PicoPlacas(obj);

            Assert.AreEqual(expected, result);


        }


    }
}
