using Kowalski.PW_projekt_zaliczeniowy.BussinesLogicv2;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleUIv2.Properties;

namespace ConsoleUIv2
{
    class Program
    {
        static void Main(string[] args)
        {
            InjectDllNameToBL();
            var players = BusinessLogic.Instance.GetAllPlayers();
            foreach(var player in players)
            {
                Console.WriteLine(player.Name);
            }
        }

        private static void InjectDllNameToBL()
        {
            BusinessLogic.Instance.DllName = Settings.Default.dllName;
        }
    }
}
