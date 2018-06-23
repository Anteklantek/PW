using System;
using System.Collections.Generic;
using System.Text;
using Kowalski.PW_projekt_zaliczeniowy.Interfaces;

namespace Kowalski.PW_projekt_zaliczeniowy.DAO
{
    class Club : IClub
    {
        public string Name { get; set; }
        public string City { get; set; }
        public int establishmentYear { get; set; }

        public Club(string name, string city, int establishmentYear)
        {
            Name = name;
            City = city;
            this.establishmentYear = establishmentYear;
        }
    }
}
