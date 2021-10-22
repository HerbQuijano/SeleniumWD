using System;

namespace SeleniumWD.MidTerm_Exam
{
    internal class Receipt
    {
        private int receiptNum, customerID, itemID, itemQty;
        private string purchaseDate, customerFirstName, customerLastName, customerAddress, custPhone, itemDescription;
        private double unitPrice, totalCost;

        public Receipt(int receiptNum, int customerID, int itemID, int itemQty, string purchaseDate, string customerFName, string customerLName, string customerAddress, string custPhone, string itemDescription, double unitPrice)
        {
            ReceiptNum = receiptNum;
            CustomerID = customerID;
            ItemID = itemID;
            ItemQty = itemQty;
            PurchaseDate = purchaseDate;
            CustomerFirstName = customerFName;
            CustomerLastName = customerLName;
            CustomerAddress = customerAddress;
            CustPhone = custPhone;
            ItemDescription = itemDescription;
            UnitPrice = unitPrice;
        }

        public int ReceiptNum
        {
            get => receiptNum;
            set
            {
                if (value > 0)
                {
                    receiptNum = value;
                }
                else
                {
                    receiptNum = -1;
                    Console.WriteLine("Invalid receipt Number, cannot be zero or negative");
                }
            }
        }

        public int CustomerID
        {
            get => customerID;
            set
            {
                if (value > 0)
                {
                    customerID = value;
                }
                else
                {
                    customerID = -1;
                    Console.WriteLine("Invalid customerID, cannot be zero or negative");
                }
            }
        }

        public int ItemID
        {
            get
            {
                return itemID;
            }
            set
            {
                if (value > 0 && value < 9999)
                {
                    itemID = value;
                }
                else
                {
                    Console.WriteLine("Invalid itemID, cannot be zero or negative");
                }
            }
        }

        public int ItemQty
        {
            get
            {
                return itemQty;
            }
            set
            {
                if (value > 0)
                {
                    itemQty = value;
                }
                else
                {
                    Console.WriteLine("Invalid quantity, cannot be zero or negative");
                }
            }
        }

        public string PurchaseDate { get => purchaseDate; set => purchaseDate = value; }
        public string CustomerFirstName { get => customerFirstName; set => customerFirstName = value; }
        public string CustomerLastName { get => customerLastName; set => customerLastName = value; }
        public string CustomerAddress { get => customerAddress; set => customerAddress = value; }
        public string CustPhone { get => custPhone; set => custPhone = value; }
        public string ItemDescription { get => itemDescription; set => itemDescription = value; }

        public double UnitPrice
        {
            get => unitPrice; set
            {
                if (value > 0 && value < 9999)
                {
                    unitPrice = value;
                }
                else
                {
                    Console.WriteLine("Invalid unit price, cannot be zero, negative or larger than 9999");
                }
            }
        }

        public double Calculate_Total()
        {
            totalCost = unitPrice * itemQty;
            return totalCost;
        }

        public override string ToString()
        {
            return "Customer: " + customerFirstName + " " + customerLastName + "\nPhone: " + custPhone + " " + "\nTotal Purchases: " + Calculate_Total().ToString("C");
        }
    }
}