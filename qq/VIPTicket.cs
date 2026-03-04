using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace qq
{
    internal class VIPTicket : Ticket ,IPrintable
    {

        private const decimal ServiceFee = 50m;
        public bool LoungeAccess { get; set; }
        public VIPTicket(string moviename, decimal price, bool Loungeaccess) : base(moviename, price + ServiceFee)
        {
            LoungeAccess = Loungeaccess;
        }
        public override string ToString()
        {
            return base.ToString()
                   + $", Lounge Access: {LoungeAccess}, Service Fee: {ServiceFee}";
        }

        public void Print()
        {
            Console.WriteLine(ToString());
        }
        public override Ticket Clone()
        {
            return new VIPTicket(MovieName, Price, LoungeAccess);
        }
    }
}
