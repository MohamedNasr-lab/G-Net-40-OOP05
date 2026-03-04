using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace qq
{
    internal class IMAXTicket : Ticket , IPrintable
    {

        public bool Is3D { get; }

        public IMAXTicket(string moviename, decimal price, bool Is3D) : base(moviename, Is3D ? price + 30 : price)
        {
            this.Is3D = Is3D;

        }

        public override string ToString()
        {
            return base.ToString()
                + $", IMAX 3D: {Is3D}";
        }

        public void Print()
        {
            Console.WriteLine(ToString());
        }
    }
}
