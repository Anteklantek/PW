using Kowalski.PW_projekt_zaliczeniowy.BussinesLogicv2;
using Kowalski.PW_projekt_zaliczeniowy.Interfacesv2;
using PW_projekt_zaliczeniowy.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Kowalski.PW_projekt_zaliczeniowy.PW_projekt_zaliczeniowy
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        Dictionary<string, List<string>> propErrors = new Dictionary<string, List<string>>();

        public IPlayer _selectedPlayer;
        public IPlayer SelectedPlayer
        {
            get
            {
                return _selectedPlayer;
            }

            set
            {
                if (value != _selectedPlayer)
                {
                    _selectedPlayer = value;
                }
            }
        }

        private List<IPlayer> _players;
        public List<IPlayer> Players
        {
            get { return _players; }
            set { _players = value; }
        }


        

        public MainWindowViewModel()
        {

            Players = new List<IPlayer>(BusinessLogic.Instance.GetAllPlayers());
        }

    }
}
