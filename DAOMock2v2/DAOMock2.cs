using Kowalski.PW_projekt_zaliczeniowy.Interfacesv2;
using Kowalski.PW_projekt_zaliczeniowy.DAOv2;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kowalski.PW_projekt_zaliczeniowy.DAOMock2v2
{
    public class DAOMock2 : IDAO
    {
        public IList<IPlayer> Players { get; } = new List<IPlayer>();
        public IList<IClub> Clubs { get; } = new List<IClub>();

        public DAOMock2()
        {
            var lechia = new Club("Lechia", "Gdańsk", 1945);
            var bayern = new Club("Bayern", "Monachium", 1900);

            Clubs.Add(lechia);
            Clubs.Add(bayern);

            var peszko = new Player(lechia, "Sławomir", "Peszko", Corev2.Position.Striker);
            var lewandowski = new Player(bayern, "Robert", "Lewandowski", Corev2.Position.Striker);

            Players.Add(peszko);
            Players.Add(lewandowski);

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
