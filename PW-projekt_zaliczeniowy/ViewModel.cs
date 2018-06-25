using Kowalski.PW_projekt_zaliczeniowy.BussinesLogicv2;
using Kowalski.PW_projekt_zaliczeniowy.Corev2;
using Kowalski.PW_projekt_zaliczeniowy.Interfacesv2;
using PW_projekt_zaliczeniowy;
using PW_projekt_zaliczeniowy.Properties;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kowalski.PW_projekt_zaliczeniowy.PW_projekt_zaliczeniowy
{
    class ViewModel
    {
        public ClubListViewModel ClubListViewModel { get; set; }
        public PlayerListViewModel PlayerListViewModel { get; set; }

        public ViewModel()
        {
            InjectDllNameToBL();
            ClubListViewModel = new ClubListViewModel();
            PlayerListViewModel = new PlayerListViewModel();
        }

        private static void InjectDllNameToBL()
        {
            BusinessLogic.Instance.DllName = Settings.Default.dllName;
        }
    }
}
