using Kowalski.PW_projekt_zaliczeniowy.BussinesLogic;
using System;

namespace BasicUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var clubs = BusinessLogic.Instance.GetAllClubs();
            var players = BusinessLogic.Instance.GetAllProducts();

            foreach(var club in clubs)
            {
                Console.WriteLine(club.Name);
            }

            foreach (var player in players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
