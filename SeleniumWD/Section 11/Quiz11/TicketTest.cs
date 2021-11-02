using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SeleniumWD.Section_11.Quiz11
{
    [TestClass]
    public class TicketTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DateTime play01EventDate = new DateTime(2021, 05, 05);
            DateTime lecture01EventDate = new DateTime(2021, 11, 18);
            DateTime musical01EventDate = new DateTime(2021, 12, 25);

            Play play01 = new Play(2, 34, "F", play01EventDate, 25.50, "Othelo", "Vericcio", true);
            Lecture lecture1 = new Lecture(564, 86, "K", lecture01EventDate, 180.00, "Electrocardiograma como metodo para salvar vidas", "Dr. Martinez Avogadro", "Cardiologia", true);
            Musical musical01 = new Musical(45, 28, "S", musical01EventDate, 300.00, "Lago de los cisnes", "Lomonaco", true);

            Console.WriteLine(play01);
            Assert.AreEqual(true, play01.IsValid);
            
            
            //Console.WriteLine(lecture1);
            //Console.WriteLine(musical01);

        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]

        public void TestMethod2()
        {
            DateTime play01EventDate = new DateTime(2021, 05, 05);
            Play play01 = new Play(2, 34, "F", play01EventDate, 25.50, "Othelo", "Vericcio", true);

            play01.IsValid = false;
            Console.WriteLine(play01);
            Assert.AreEqual(true, play01.IsValid);
        }
    }
}