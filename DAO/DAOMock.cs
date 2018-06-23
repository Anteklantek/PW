using Kowalski.PW_projekt_zaliczeniowy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kowalski.PW_projekt_zaliczeniowy.DAO
{
    public class DAOMock : IDAO
    {
        public IList<IPlayer> Players { get; } = new List<IPlayer>();
        public IList<IClub> Clubs { get; } = new List<IClub>();

        public DAOMock()
        {
            var juve = new Club("Juventus", "Turyn", 1897);
            var legia = new Club("Legia", "Warszawa", 1916);

            Clubs.Add(juve);
            Clubs.Add(legia);

            var szczesny = new Player(juve, "Wojtek", "Sczęsny", Core.Position.Goalkeeper);
            var pazdan = new Player(legia, "Michał", "Pazdan", Core.Position.Defender);

            Players.Add(szczesny);
            Players.Add(pazdan);

        }

        public IEnumerable<IPlayer> GetAllPlayers()
        {
            return Players;
        }

        public IEnumerable<IClub> GetAllClubs()
        {
            return Clubs;
        }
    }
}
