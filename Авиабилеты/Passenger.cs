using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Авиабилеты
{
    public class Passenger
    {
         public string fio;
        public string name;
         public DateTime dateOfBirth;
         public int passportSeries;
         public int passportNumber;
        private (string, string, DateTime, int, int) value;

        public Passenger(string fio, string name, DateTime dateOfBirth, int passportSeries, int passportNumber)
        {
            this.fio = fio;
            this.name = name;
            this.dateOfBirth = dateOfBirth;
            this.passportSeries = passportSeries;
            this.passportNumber = passportNumber;
        }

        public Passenger((string, string, DateTime, int, int) value)
        {
            this.value = value;
        }

        public string Fio()
        {
            return this.fio;
        }
        public string Name()
        {
            return this.name;
        }
        public DateTime dateOfbirth()
        {
            return this.dateOfBirth;
        }
        public int PasS()
        {
            return this.passportSeries;
        }
        public int passN()
        {
            return this.passportNumber;
        }

    }
    
}

