using qq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace qq
{
    internal class Cinema : IPrintable
    {
        public string CinemaName { get; set; }
        private Projector Projector;
        private Ticket[] tickets = new Ticket[20];

        private int ticketCount = 0;

        public Cinema(string cinemaName)
        {
            CinemaName = cinemaName;
            Projector = new Projector();
        }



        public void AddTicket(Ticket t)
        {
            if (ticketCount < tickets.Length)
            {
                tickets[ticketCount] = t;
                ticketCount++;
            }
            else
            {
                Console.WriteLine("Cinema is full. Cannot add more tickets.");
            }
        }

        public void PrintAllTickets()
        {
            Console.WriteLine($"=== Tickets in {CinemaName} ===");

            for (int i = 0; i < ticketCount; i++)
            {
                Console.WriteLine(tickets[i]);
            }
        }
        public void OpenCinema()
        {
            Console.WriteLine("========== Cinema Opened ==========");
            Projector.Start();
        }

        public void CloseCinema()
        {
            Console.WriteLine("========== Cinema Closed ==========");
            Projector.Stop();
        }

        public void Print()
        {
            PrintAllTickets();
        }
    }
}
