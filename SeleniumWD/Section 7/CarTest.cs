using Microsoft.VisualStudio.TestTools.UnitTesting;

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

        [TestMethod]
        public void Call_Acceleration_Method()
        {
            //arrange
            Car myCar = new Car("Red", 2, true);

            //ask
            myCar.Accelerate();
        }

        [TestMethod]
        public void Call_FamilyCar_Method()
        {
            Car myCar = new Car("Red", 4, true);

            bool carType = myCar.FamilyCar();

            if (carType == true)
            {
                Assert.IsTrue(carType == true);
            }
            else
            {
                Assert.Fail();
            }
        }
    }
}