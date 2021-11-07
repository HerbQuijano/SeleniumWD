using System;

namespace SeleniumWD.Section_7.Section_Exam
{
    internal class Trip
    {
        private string destination;
        private float traveledDistance;
        private double totalFuelCost;
        private int numberOfGallons;

        public Trip(string destination, double totalFuelCost, float travelDist)
        {
            Destination = destination;
            TotalFuelCost = totalFuelCost;
            TraveledDistance = travelDist;
        }

        public Trip(string destination, float travelDist, int numberOfGallons)
        {
            Destination = destination;
            TraveledDistance = travelDist;
            NumberOfGallons = numberOfGallons;
        }

        public Trip(string destination, float traveledDistance, double totalFuelCost, int numberOfGallons)
        {
            Destination = destination;
            TraveledDistance = traveledDistance;
            TotalFuelCost = totalFuelCost;
            NumberOfGallons = numberOfGallons;
        }

        public string Destination

        {
            get { return destination; }
            set
            {
                destination = value;
            }
        }

        public float TraveledDistance
        {
            get
            {
                return traveledDistance;
            }

            set
            {
                if (value >= 0)
                {
                    traveledDistance = value;
                }
                else
                {
                    Console.WriteLine("Traveled Distance is 0 or less");
                }
            }
        }

        public double TotalFuelCost
        {
            get
            {
                return totalFuelCost;
            }
            set
            {
                totalFuelCost = value;
            }
        }

        public int NumberOfGallons
        {
            get => numberOfGallons;
            set => numberOfGallons = value;
        }

        public float Calculate_MPG()
        {
            float milesPerGallon = TraveledDistance / NumberOfGallons;
            return milesPerGallon;
        }

        public double Calculate_Cost_Per_Mile()
        {
            double costPerGallon = TotalFuelCost / TraveledDistance;
            return costPerGallon;
        }

        public override string ToString()
        {
            return $"The trip was to {Destination} with a distance of {TraveledDistance} miles and a total cost of ${TotalFuelCost} used {NumberOfGallons} gallons";
        }
    }
}