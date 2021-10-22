using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeleniumWD.MidTerm_Exam
{
    [TestClass]
    [TestCategory("Midterm Exam")]
    public class ReceiptTest
    {
        [TestMethod]
        public void Calculate_Total_Valid()
        {
            Receipt receipt = new Receipt(1, 1, 3, 6, "02/02/82", "Flavio", "Marito", "223 Risk Drive", "8643729957", "Shovel and gloves", 45.00d);

            Assert.AreEqual(270.00, receipt.Calculate_Total());
        }

        [TestMethod]
        public void Calculate_Total_Invalid()
        {
            Receipt receipt = new Receipt(1, 1, 3, 6, "02/02/82", "Flavio", "Marito", "223 Risk Drive", "8643729957", "Shovel and gloves", 45.00d);
            Assert.AreEqual(280.00, receipt.Calculate_Total());
        }

        [TestMethod]
        public void Receipt_Greater_Than_Zero()
        {
            Receipt receipt = new Receipt(56, 1, 3, 6, "02/02/82", "Flavio", "Marito", "223 Risk Drive", "8643729957", "Shovel and gloves", 445.00d);
            //Assert.IsTrue(receipt.ReceiptNum > 0);
            Assert.AreEqual(56, receipt.ReceiptNum);
        }

        [TestMethod]
        public void CustomerID_Greater_Than_Zero()
        {
            Receipt receipt = new Receipt(3, 1, 5, 45, "02/02/82", "Flavio", "Marito", "223 Risk Drive", "8643729957", "Shovel and gloves", 32.00d);
            Assert.IsTrue(receipt.CustomerID > 0);
        }

        [TestMethod]
        public void Item_Greater_Than_Zero_Less_Than_9999()
        {
            Receipt receipt = new Receipt(4, 1, 445, 65, "02/02/82", "Flavio", "Marito", "223 Risk Drive", "8643729957", "Shovel and gloves", 676.00d);
            Assert.IsTrue(receipt.ItemID > 0 && receipt.ItemID < 9999);
        }

        [TestMethod]
        public void Unit_Price_Greater_Than_Zero_Less_Than_9999()
        {
            Receipt receipt = new Receipt(5, 1, 43, 535, "02/02/82", "Flavio", "Marito", "223 Risk Drive", "8643729957", "Shovel and gloves", 9998.00d);
            Assert.IsTrue(receipt.UnitPrice > 0 && receipt.UnitPrice < 9999);
        }

        [TestMethod]
        public void Quantity_Greater_Than_Zero()
        {
            Receipt receipt = new Receipt(5, 1, 43, 34, "02/02/82", "Flavio", "Marito", "223 Risk Drive", "8643729957", "Shovel and gloves", 9998.00d);
            Assert.IsTrue(receipt.ItemQty > 0);
        }
    }
}