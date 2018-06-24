using Kowalski.PW_projekt_zaliczeniowy.BussinesLogicv2;
using Kowalski.PW_projekt_zaliczeniowy.Interfacesv2;
using PW_projekt_zaliczeniowy.Properties;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PW_projekt_zaliczeniowy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

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
                    OnPropertyChanged("SelectedPlayer");
                }
            }
        }

        private List<IPlayer> _players;
        public List<IPlayer> Players
        {
            get { return _players; }
            set { _players = value; }
        }


        private List<IClub> _clubs;
        public List<IClub> Clubs
        {
            get { return _clubs; }
            set { _clubs = value; }
        }


        public IClub _selectedClub;
        public IClub SelectedClub
        {
            get
            {
                return _selectedClub;
            }

            set
            {
                if (value != _selectedClub)
                {
                    _selectedClub = value;
                    OnPropertyChanged("SelectedClub");
                }
            }
        }




        public MainWindow()
        {
            InjectDllNameToBL();
            Players = new List<IPlayer>(BusinessLogic.Instance.GetAllPlayers());
            Clubs = new List<IClub>(BusinessLogic.Instance.GetAllClubs());
            InitializeComponent();
            DataContext = this;
        }
        private static void InjectDllNameToBL()
        {
            BusinessLogic.Instance.DllName = Settings.Default.dllName;
        }

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
