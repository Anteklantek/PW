using Kowalski.PW_projekt_zaliczeniowy.Corev2;
using Kowalski.PW_projekt_zaliczeniowy.Interfacesv2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kowalski.PW_projekt_zaliczeniowy.DAOv2
{
    public class Player : IPlayer
    {
        public Club Club { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Kowalski.PW_projekt_zaliczeniowy.Corev2.Position Position { get; set; }

        public Player(Club club, string name, string surname, Position position)
        {
            Club = club;
            Name = name;
            Surname = surname;
            Position = position;
        }


        public string ToString
        {
            get
            {
                return Name + " " + Surname;
            }
        }
    }
}
