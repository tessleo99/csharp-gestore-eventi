using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    public class Event
    {
        //ATTRIBUTES
        private string eventName;
        private DateTime eventDate;
        private int seatsMax;
        private int seatsBooked;

        //CONSTRUCTOR
        public Event (string eventName,  string eventDateString, int seatsMax, int seatsBooked = 0)
        {   
            if (seatsMax  <= 0) 
            {
                throw new Exception("Il numero massimo di posti inserito non è valido perchè è un numero negativo (o uguale a 0)");
            }
            this.eventName = eventName;
            this.eventDate = DateTime.Parse(eventDateString);
            this.seatsMax = seatsMax;
            this.seatsBooked = seatsBooked; 
        }

        //GETTERS
        public string GetEventName()
        { 
            return this.eventName;
        }

        public DateTime GetEventDate()
        {
            return this.eventDate;
        }

        public int GetSeatsMax()
        {
            return this.seatsMax;
        }

        public int GetSeatsBooked()
        { 
            return this.seatsBooked; 
        }

        //SETTERS
        public void SetEventName (string newEventName)
        {
            if (newEventName == "")
            {
                throw new ArgumentException("Inserisci un nome per l'evento!");
            }
            this.eventName = newEventName;
        }

        public void SetEventDate (string newEventDateString)
        {   
            DateTime newEventDate = DateTime.Parse(newEventDateString);
            if (newEventDate < DateTime.Now)
            {
                throw new Exception("L'evento è già passato: te lo sei perso?!");
            }
            this.eventDate = newEventDate;
        }

        //METHODS

        //prenota dei posti
        public void BookingSeats (int plusSeatsBooking) 
        {
            if (eventDate <  DateTime.Now)
            {
                throw new Exception("Non puoi acquistare biglietti per un evento che si è già tenuto");
            } 
            else if (seatsBooked == seatsMax) 
            {
                throw new Exception("I posti prenotabili sono tutti esauriti");
            }
            else
            {
                int newSeatsBookeed = seatsBooked + plusSeatsBooking;

                if (newSeatsBookeed > seatsMax)
                {
                    throw new Exception("Non puoi prenotare così tanti posti perchè non sono disponibili");
                }
                else
                {
                    seatsBooked = newSeatsBookeed;
                    Console.WriteLine("I posti prenotati sono: " + seatsBooked);
                } 

            }
        }

        //disdici dei posti
        public void CancelSeatsReservation(int minumSeatsBooking)
        {
            if (eventDate < DateTime.Now)
            {
                throw new Exception("Non puoi disdire biglietti per un evento che si è già tenuto");

            } else if (seatsBooked == 0)
            {
                throw new Exception("Non esistono prenotazioni da poter cancellare");

            } else
            {
                //int noSeatsBookeed = seatsBooked - minumSeatsBooking;

                if (seatsBooked < minumSeatsBooking)
                {
                    throw new Exception("Non puoi disdire così tanti posti perchè superano quelli prenotati");
                } else
                {
                    seatsBooked -= minumSeatsBooking;
                    Console.WriteLine("I posti prenotati sono: " + seatsBooked);
                }
            }
        }

        public override string ToString()
        {
            string infoEvent =
               $"Info Evento: " + eventDate.ToString("dd/MM/yyyy") + "-" + eventName;
            return infoEvent;
                
        }

    }
}
