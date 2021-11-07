using System;

namespace SeleniumWD.Section_11.Quiz11
{
    abstract class Ticket
    {
        private int ticketNumber;
        private int seatNumber;
        private string seatRow;
        private double ticketPrice;
        private DateTime eventDate;
        private bool isValid;

        public Ticket()
        {
        }

        public Ticket(int ticketNumber, int seatNumber, string seatRow, DateTime eventDate, double ticketPrice, bool isValid)
        {
            TicketNumber = ticketNumber;
            SeatNumber = seatNumber;
            SeatRow = seatRow;
            TicketPrice = ticketPrice;
            EventDate = eventDate;
            IsValid = isValid;
        }

        public int TicketNumber { get => ticketNumber; set => ticketNumber = value; }
        public int SeatNumber { get => seatNumber; set => seatNumber = value; }
        public string SeatRow { get => seatRow; set => seatRow = value; }
        public double TicketPrice { get => ticketPrice; set => ticketPrice = value; }
        public DateTime EventDate { get => eventDate; set => eventDate = value; }
        public bool IsValid { get => isValid; set => isValid = value; }

        public abstract DateTime GetTicketDate();

        public abstract bool GetTicketStatus();

        public void SetTicketStatus(bool isValidT)
        {
            IsValid = isValidT;
        }
    }
}