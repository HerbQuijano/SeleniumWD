using System;

namespace SeleniumWD.Section_11.Quiz11
{
    internal class Musical : Ticket
    {
        private string bandName;
        private string directorName;

        public string BandName { get => bandName; set => bandName = value; }
        public string DirectorName { get => directorName; set => directorName = value; }

        public Musical(int ticketN, int seatN, string seatR, DateTime eventD, double price, string bandN, string direcName, bool isValid) : base(ticketN, seatN, seatR, eventD, price, isValid)
        {
            BandName = bandN;
            DirectorName = direcName;
        }

        public override DateTime GetTicketDate()
        {
            return EventDate;
        }

        public override bool GetTicketStatus()
        {
            return IsValid;
        }

        public string GetDirectorName()
        {
            return directorName;
        }

        public override string ToString()
        {
            return $"Ticket Number: {TicketNumber}\n Seat: {SeatNumber} \n  Row: {SeatRow} \n Date: {EventDate} \n Band Name: {BandName} \n Director: {DirectorName} \n Price: {TicketPrice} \n";
        }
    }
}