using System;

namespace SeleniumWD.Section_11.Quiz11
{
    class Lecture : Ticket
    {
        private string lectureName;
        private string oratorName;
        private string lectureSubject;

        public string LectureName { get => lectureName; set => lectureName = value; }
        public string LectureSubject { get => lectureSubject; set => lectureSubject = value; }
        public string OratorName { get => oratorName; set => oratorName = value; }

        public Lecture(int ticketN, int seatN, string seatR, DateTime eventD, double tPrice, string lectureN, string oratorN, string lectSubj, bool isValid) : base(ticketN, seatN, seatR, eventD, tPrice, isValid)
        {
            LectureName = lectureN;
            OratorName = oratorN;
            LectureSubject = lectSubj;
        }

        public override DateTime GetTicketDate()
        {
            return EventDate;
        }

        public override bool GetTicketStatus()
        {
            return IsValid;
        }

        public string GetOratorName()
        {
            return oratorName;
        }

        public override string ToString()
        {
            return $"Ticket Number: {TicketNumber}\n Seat: {SeatNumber} \n  Row: {SeatRow} \n Date: {EventDate} \n Lecture: {LectureName} \n Subject: {LectureSubject} \n Orator: {OratorName} \n Price: {TicketPrice} \n";
        }
    }
}