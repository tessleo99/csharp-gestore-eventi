// See https://aka.ms/new-console-template for more information
using GestoreEventi;

Console.Write("Qual è il titolo del tuo programma eventi? ");
string eventSchedule = Console.ReadLine();

EventSchedule EventScheduleUser = new EventSchedule(eventSchedule);

Console.Write("Quanti eventi vuoi aggiungere nel tuo programma? ");
int numbersOfEvent = int.Parse(Console.ReadLine());

    for (int i = 0; i < numbersOfEvent; i++)
        {
            try 
            { 
                Console.Write($"Che nome ha il {i+1}° evento? ");
                string eventName = Console.ReadLine();

                Console.Write("Inserisci la data dell'evento (formato: dd/MM/yyyy): ");
                string eventDate = Console.ReadLine();

                Console.Write("Quante persone possono partecipare all'evento? ");
                int seatsMax = int.Parse(Console.ReadLine());

                Event EventUser = new Event(eventName, eventDate, seatsMax);

                EventScheduleUser.AddEvent(EventUser);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERRORE: " + ex.Message);
            }
     
        }


Console.WriteLine("Il numero di eventi nel programma è: " + EventScheduleUser.GetNumberOfEvent());

Console.Write("Inserisci una data per sapere che eventi ci saranno (formato: dd/MM/yyyy): ");
string eventScheduleDate = Console.ReadLine();
EventScheduleUser.listEventSameDate(eventScheduleDate);

Console.WriteLine(EventScheduleUser.ToString());





//EventScheduleUser.EmptyListOfEvent();

//Console.Write("Che nome ha l'evento? ");
//string eventName = Console.ReadLine();

//Console.Write("Inserisci la data dell'evento (formato: dd/MM/yyyy): ");
//string eventDate = Console.ReadLine();

//Console.Write("Quante persone possono partecipare all'evento? ");
//int seatsMax = int.Parse(Console.ReadLine());

//Event Conferenza = new Event(eventName, eventDate, seatsMax);

//Console.Write("Quanti posti desideri prenotare? ");
//int seatsBooked = int.Parse(Console.ReadLine());
//Conferenza.BookingSeats(seatsBooked);

//Console.Write("Vuoi disdire dei posti (si/no)? ");
//string cancelSeats = Console.ReadLine();

//    while (cancelSeats == "si")
//    {
//        Console.Write("Quanti posti vuoi disdire? ");
//        int numberCancel = int.Parse(Console.ReadLine());
//        Conferenza.CancelSeatsReservation(numberCancel);
//        Console.Write("Vuoi disdire dei posti (si/no)? ");
//        cancelSeats = Console.ReadLine();
//        Console.WriteLine("Va bene!");
//    }

//Console.WriteLine(Conferenza.ToString());

//EventSchedule Pianeti = new EventSchedule("Pianeti");

//Event Conferenza1 = new Event("Pianeta Venere", "12/06/2023", 200);
//Event Conferenza2 = new Event("Pianeta Terra", "12/06/2023", 150);
//Event Conferenza3 = new Event("Pianeta Terra", "17/06/2023", 150);

//Pianeti.AddEvent(Conferenza1);
//Pianeti.AddEvent(Conferenza2);
//Pianeti.AddEvent(Conferenza3);

//Console.WriteLine( Pianeti.ToString());
//Console.WriteLine(Pianeti.GetNumberOfEvent());

//Pianeti.listEventSameDate("12/06/2023");
