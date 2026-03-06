using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static G_NET_26_OOP_5.Program;

namespace G_NET_26_OOP_5
{
    internal class StandardTicket : Ticket, IPrintable, IBookable
    {
        public bool IsBooked { get; private set; }

        public bool Book()
        {
            if (IsBooked)
                return false;

            IsBooked = true;
            return true;
        }

        public bool Cancel()
        {
            if (!IsBooked)
                return false;

            IsBooked = false;
            return true;
        }

        public void Print()
        {
            Console.WriteLine($"Standard Ticket - Movie: {MovieName}, Price: {Price}");
        }
    }
    
    }

