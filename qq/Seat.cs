using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qq
{
    public struct Seat
    {
        public char row;
        public int number;

        public override string ToString()
        {
            return $"{row}{number}";
        }
    }
}
