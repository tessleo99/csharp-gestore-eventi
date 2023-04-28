// See https://aka.ms/new-console-template for more information
using GestoreEventi;


Console.Write("Che nome ha l'evento? ");
string eventName = Console.ReadLine();

Console.Write("Inserisci la data dell'evento (formato: dd/MM/yyyy): ");
string eventDate = Console.ReadLine();

Console.Write("Quante persone possono partecipare all'evento? ");
int seatsMax = int.Parse(Console.ReadLine());

Event Conferenza = new Event(eventName, eventDate, seatsMax);

Console.WriteLine("Quanti posti desideri prenotare? ");
int seatsBooked = int.Parse(Console.ReadLine());

Conferenza.BookingSeats(seatsBooked);

Console.WriteLine(Conferenza.ToString());



//Event Conferenza = new Event("Pianeta Terra", "12/06/2023", 150);

//Console.WriteLine(Conferenza.ToString());

//Conferenza.BookingSeats(150);

//Conferenza.CancelSeatsReservation(10);