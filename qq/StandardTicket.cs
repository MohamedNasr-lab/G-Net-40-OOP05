using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace qq
{
    internal class StandardTicket : Ticket , IPrintable
    {
        private string SeatNumber;
        public StandardTicket(string moviename, decimal price, string seatnumber) : base(moviename, price)
        {
            SeatNumber = seatnumber;
        }

        public void Print()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return base.ToString()
                   + $", SeatNumber: {SeatNumber}";
        }

    }
}
