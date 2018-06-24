using System;
using System.Collections.Generic;
using System.Text;
using Kowalski.PW_projekt_zaliczeniowy.Interfacesv2;

namespace Kowalski.PW_projekt_zaliczeniowy.DAOv2
{
    public class Club : IClub
    {
        public string Name { get; set; }
        public string City { get; set; }
        public int EstablishmentYear { get; set; }

        public Club(string name, string city, int establishmentYear)
        {
            Name = name;
            City = city;
            this.EstablishmentYear = establishmentYear;
        }

        public string ToString
        {
            get
            {
                return Name + " " + City;
            }
        }
    }
}
