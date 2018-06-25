using System;
using System.Collections.Generic;
using System.Text;
using Kowalski.PW_projekt_zaliczeniowy.Interfacesv2;

namespace Kowalski.PW_projekt_zaliczeniowy.DAOv2
{
    [Serializable]
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

        public Club()
        {
        }

        public string ToString
        {
            get
            {
                return Name + " " + City;
            }
        }

        public override bool Equals(object obj)
        {
            var club = obj as Club;
            return club != null &&
                   Name == club.Name &&
                   City == club.City &&
                   EstablishmentYear == club.EstablishmentYear;
        }

        public override int GetHashCode()
        {
            var hashCode = 1679379841;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(City);
            hashCode = hashCode * -1521134295 + EstablishmentYear.GetHashCode();
            return hashCode;
        }
    }
}
