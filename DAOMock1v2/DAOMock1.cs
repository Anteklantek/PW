using Kowalski.PW_projekt_zaliczeniowy.Interfacesv2;
using System;
using System.Collections.Generic;
using System.Text;
using Kowalski.PW_projekt_zaliczeniowy.DAOv2;

namespace Kowalski.PW_projekt_zaliczeniowy.DAOMock1v2
{
    public class DAOMock1 : IDAO
    {
        public IList<IPlayer> Players { get; } = new List<IPlayer>();
        public IList<IClub> Clubs { get; } = new List<IClub>();

        public DAOMock1()
        {
            var juve = new Club("Juventus", "Turyn", 1897);
            var legia = new Club("Legia", "Warszawa", 1916);

            Clubs.Add(juve);
            Clubs.Add(legia);

            var szczesny = new Player(juve, "Wojtek", "Sczęsny", Corev2.Position.Goalkeeper);
            var pazdan = new Player(legia, "Michał", "Pazdan", Corev2.Position.Defender);

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
