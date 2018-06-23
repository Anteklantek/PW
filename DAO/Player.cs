using Kowalski.PW_projekt_zaliczeniowy.Core;
using Kowalski.PW_projekt_zaliczeniowy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kowalski.PW_projekt_zaliczeniowy.DAO
{
    class Player : IPlayer
    {
        public Club Club { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Kowalski.PW_projekt_zaliczeniowy.Core.Position Position { get; set; }

        public Player(Club club, string name, string surname, Position position)
        {
            Club = club;
            Name = name;
            Surname = surname;
            Position = position;
        }
    }
}
