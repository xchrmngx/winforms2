using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Авиабилеты
{
    public class Ticket
    {
        public string passanger;
        public string whereFrom;
        public string whereTo;
        public int price;
        public string date;

        public Ticket()
        {
        }

        public Ticket(string passanger, string whereFrom, string whereTo, int price, string date)
        {
            this.passanger = passanger;
            this.whereFrom = whereFrom;
            this.whereTo = whereTo;
            this.price = price;
            this.date = date;
        }

        public string pas()
        {
            return this.passanger;
        }
        public string WhereFrom()
        {
            return this.whereFrom;
        }
        public string whereto()
        {
            return this.whereTo;
        }
        public int Price()
        {
            return this.price;
        }
        public string Date()
        {
            return this.date;
        }
    }
}
