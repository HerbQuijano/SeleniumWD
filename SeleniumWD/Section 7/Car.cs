using System;

namespace SeleniumWD.Section_7
{
    internal class Car
    {
        //variables
        private string color;

        private int numberOfDoors;
        private bool isConvertable;

        //Constructor
        public Car(string color, int doors, bool convertable)
        {
            Color = color;
            NumberOfDoors = doors;
            IsConvertable = convertable;
        }

        //Accesor - Properties that define attributes of the class
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                this.color = value;
            }
        }

        public bool IsConvertable
        {
            get
            {
                return isConvertable;
            }
            set
            {
                this.isConvertable = value;
            }
        }

        public int NumberOfDoors
        {
            get
            {
                return numberOfDoors;
            }

            set
            {
                if (value > 0 && value <= 5)
                {
                    this.numberOfDoors = value;
                }
                else
                {
                    Console.WriteLine("Invalid number of doors, resetting to 4");
                    this.numberOfDoors = 4;
                }
            }
        }

        //Method - Function
        public void Accelerate()
        {
            Console.WriteLine("Accelerating");
        }

        public bool FamilyCar()
        {
            if (NumberOfDoors >= 4)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Not a family car");
                return false;
            }
        }
    }
}