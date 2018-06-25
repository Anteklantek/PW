using Kowalski.PW_projekt_zaliczeniowy.Corev2;
using Kowalski.PW_projekt_zaliczeniowy.Interfacesv2;
using Kowalski.PW_projekt_zaliczeniowy.PW_projekt_zaliczeniowy;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kowalski.PW_projekt_zaliczeniowy.PW_projekt_zaliczeniowy
{
    class PlayerViewModel : ViewModelBase
    {

        private IPlayer _player;
        public IPlayer Player
        {
            get => _player;
        }

        public PlayerViewModel(IPlayer player)
        {
            _player = player;
        }

        [Required(ErrorMessage = "Podaj imię")]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "Długość nazwy musi być w przedziale <1,30>")]
        public string Name
        {
            get => _player.Name;
            set
            {
                _player.Name = value;
                Validate();
                RaisePropertyChanged("Name");
            }
        }

        [Required(ErrorMessage = "Podaj nazwisko")]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "Długość nazwiska musi być w przedziale <1,30>")]
        public string Surname
        {
            get => _player.Surname;
            set
            {
                _player.Surname = value;
                Validate();
                RaisePropertyChanged("Surname");
            }
        }

        [Required(ErrorMessage = "Wybierz klub")]
        public IClub Club
        {
            get => _player.Club;
            set
            {
                _player.Club = value;
                Validate();
                RaisePropertyChanged("Club");
            }
        }

        [Required(ErrorMessage = "Wybierz pozycję")]
        public Position Position
        {
            get => _player.Position;
            set
            {
                _player.Position = value;
                Validate();
                RaisePropertyChanged("Position");
            }

        }
    }
}
