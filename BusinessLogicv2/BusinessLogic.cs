using Kowalski.PW_projekt_zaliczeniowy.DAOv2;
using Kowalski.PW_projekt_zaliczeniowy.Interfacesv2;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Kowalski.PW_projekt_zaliczeniowy.BussinesLogicv2
{
    public class BusinessLogic
    {
        public string DllName
        {
            set
            {
                var assembly = Assembly.LoadFrom(@"..\..\..\" + value + @"\bin\Debug\" + value + ".dll");
                var types = assembly.GetTypes();
                Console.WriteLine(assembly);
                _dao = Activator.CreateInstance(types[0]) as IDAO;
            }
        }

        private IDAO _dao;
        public static BusinessLogic Instance { get; } = new BusinessLogic();

        public IEnumerable<IPlayer> GetAllPlayers()
        {
            return _dao.GetAllPlayers();
        }

        public IEnumerable<IClub> GetAllClubs()
        {
            return _dao.GetAllClubs();
        }

        public IClub GetClubToEdit()
        {
            return _dao.GetClubToEdit();
        }

        public IPlayer GetPlayerToEdit()
        {
            return _dao.GetPlayerToEdit();
        }
    }
}