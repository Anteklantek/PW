using Kowalski.PW_projekt_zaliczeniowy.DAO;
using Kowalski.PW_projekt_zaliczeniowy.Interfaces;
using System;
using System.Collections.Generic;

namespace Kowalski.PW_projekt_zaliczeniowy.BussinesLogic
{
    public class BusinessLogic
    {
        private readonly IDAO _dao = new DAOMock();
        public static BusinessLogic Instance { get; } = new BusinessLogic();

        public IEnumerable<IPlayer> GetAllProducts()
        {
            return _dao.GetAllPlayers();
        }

        public IEnumerable<IClub> GetAllClubs()
        {
            return _dao.GetAllClubs();
        }
    }
}