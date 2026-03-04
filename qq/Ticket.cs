using qq;
using System;

namespace qq
{
    public class Ticket :  ICloneable
    {
        public string MovieName { get; set; }
        public TicketType type;
        public Seat seat;

        protected bool IsBooked=false;

        private decimal _price;
        private static int _lastId = 0;
        public static int TotalTickets = 0;

        public int TicketId { get; }


        public void BookTicket()
        {
            if(IsBooked)
            {
                Console.WriteLine($"This ticket{TicketId} is already booked , sorry");
            }
            else
            {
                  IsBooked = true;
                Console.WriteLine($"Ticket {TicketId} is succesfully booked");
            }
        }
        public void CancelTicket()
        {
            if (IsBooked)
            {
                IsBooked = false;
                Console.WriteLine($"This ticket{TicketId} succesfully cancled");
            }
            else
            {
                Console.WriteLine($"Ticket {TicketId} is not booked");
            }
        }

        public Ticket(string movieName, decimal price)
        {
            TotalTickets++;
            TicketId = ++_lastId;
            MovieName = movieName;
            Price = price;

        }


        public decimal Price
        {
            get => _price;
            private set
            {
                if (value <= 0)
                    throw new ArgumentException("Price must be greater than 0");

                _price = value;
            }
        }

        public decimal CalcTotal(decimal taxPercent)
        {
            return Price + (taxPercent / 100m) * Price;
        }

        public void ApplyDiscount(decimal discountAmount)
        {
            if (discountAmount > 0 && discountAmount <= Price)
            {
                _price -= discountAmount;
            }
        }

        public override string ToString()
        {   
            if(IsBooked)
                return $"ID: {TicketId}, Movie: {MovieName}, Price: {Price:F2}, Total: {PriceAfterTax:F2}, Booked: Yes ";
            else
                return $" ID: {TicketId}, Movie: {MovieName}, Price: {Price:F2}, Total: {PriceAfterTax:F2}, Booked: No";

           
        }

        public decimal PriceAfterTax
        {
            get => Price + (Price * 0.14m);
        }

        public static int GetTotalTickets()
        {
            return TotalTickets;
        }

        public virtual Ticket Clone()
        {
            return new Ticket(MovieName, Price);
        }

        object ICloneable.Clone()
        {
            return Clone();
        }
    }
}