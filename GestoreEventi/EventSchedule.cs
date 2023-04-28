using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    public class EventSchedule
    {
        //ATTRIBUTI
        private string title;
        private List<Event> events;

        //COSTRUTTORE
        public EventSchedule(string title)
        {
            this.title = title;
            this.events = new List<Event>();
        }

        //GETTERS
        public List<Event> GetEventList()
        {
            return events;
        }

        //SETTERS

        //METODI

        //add event
        public void AddEvent(Event newEvent)
        {
            this.events.Add(newEvent);
        }

        //lista eventi con la stessa data

        public void listEventSameDate(string eventDateString)
            {
            DateTime eventDate = DateTime.Parse(eventDateString);
            List<Event> eventSameDate = new List<Event>();

                foreach (Event eventScan in events)
                {
                    if (eventScan.GetEventDate() == eventDate)
                    {
                        eventSameDate.Add(eventScan);
                    }
                }

                foreach (Event eventScan in eventSameDate)
                {
                    Console.WriteLine(eventDate.ToString("gg/MM/yyyy") + " - " + eventScan.GetEventName());
                }
        }
        
      

        public override string ToString()
        {
            string stringa = $"------------ LISTA EVENTI {this.title}------------\n";
            for (int i = 0; i < events.Count; i++)
            {
                stringa += $"EVENTO {i + 1}: \n";
                Event eventOfList = events[i];
                stringa += eventOfList.ToString();
                stringa += "\n";
            }
            

            return stringa;
        }

        public int GetNumberOfEvent ()
        {
            return this.events.Count;
        }

        public void EmptyListOfEvent()
        {
            this.events.Clear();
        }


    }

}
