// See https://aka.ms/new-console-template for more information
using GestoreEventi;


Console.Write("Che nome ha l'evento? ");
string eventName = Console.ReadLine();

Console.Write("Inserisci la data dell'evento (formato: dd/MM/yyyy): ");
string eventDate = Console.ReadLine();

Console.Write("Quante persone possono partecipare all'evento? ");
int seatsMax = int.Parse(Console.ReadLine());

Event Conferenza = new Event(eventName, eventDate, seatsMax);

Console.Write("Quanti posti desideri prenotare? ");
int seatsBooked = int.Parse(Console.ReadLine());
Conferenza.BookingSeats(seatsBooked);

Console.Write("Vuoi disdire dei posti (si/no)? ");
string cancelSeats = Console.ReadLine();



    while (cancelSeats == "si")
    {
        Console.Write("Quanti posti vuoi disdire? ");
        int numberCancel = int.Parse(Console.ReadLine());
        Conferenza.CancelSeatsReservation(numberCancel);
        Console.Write("Vuoi disdire dei posti (si/no)? ");
        cancelSeats = Console.ReadLine();
        Console.WriteLine("Va bene!");
    }

Console.WriteLine(Conferenza.ToString());




//Event Conferenza = new Event("Pianeta Terra", "12/06/2023", 150);

//Console.WriteLine(Conferenza.ToString());

//Conferenza.BookingSeats(150);

//Conferenza.CancelSeatsReservation(10);