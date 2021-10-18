using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SeleniumWD.Section_7
{
    [TestClass]
    public class CarTest
    {
        [TestMethod]
        public void Class_Car_Color_Set()
        {
            //arrange
            Car car1 = new Car("Red", 2, true);

            //act


            //assert
            Assert.AreEqual(car1.Color, "Red");
            Assert.AreEqual(car1.NumberOfDoors, 2);
        }
    }
}
