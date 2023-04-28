// See https://aka.ms/new-console-template for more information
using GestoreEventi;



Event Conferenza = new Event("Pianeta Terra", "12/06/2023", 150);

Console.WriteLine(Conferenza.ToString());

Conferenza.BookingSeats(150);

Conferenza.CancelSeatsReservation(10);