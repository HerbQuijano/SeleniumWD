using System;

namespace SeleniumWD.Section_11.Quiz11
{
    internal class Play : Ticket
    {
        private string playTitle;
        private string playDirector;

        public string PlayTitle { get => playTitle; set => playTitle = value; }
        public string PlayDirector { get => playDirector; set => playDirector = value; }

        public Play(int ticketN, int seatN, string seatR, DateTime eventD, double tPrice, string title, string director, bool isValid) : base(ticketN, seatN, seatR, eventD, tPrice, isValid)
        {
            PlayTitle = title;
            PlayDirector = director;
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
            return playDirector;
        }

        public override string ToString()
        {
            return $"Ticket Number: {TicketNumber}\n Seat: {SeatNumber} \n  Row: {SeatRow} \n Date: {EventDate} \n Play: {PlayTitle} \n Director: {PlayDirector} \n Price: {TicketPrice} \n";
        }
    }
}