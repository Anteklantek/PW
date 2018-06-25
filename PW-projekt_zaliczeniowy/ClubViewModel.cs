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
    class ClubViewModel : ViewModelBase
    {
        private IClub _club;
        public IClub Club
        {
            get => _club;
        }

        public ClubViewModel(IClub club)
        {
            _club = club;
        }

        [Required(ErrorMessage = "Podaj nazwe klubu")]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "Długość nazwy musi być w przedziale <1,30>")]
        [RegularExpression(@"^[a-zA-z\ ]*", ErrorMessage = "Użyj tylko liter")]
        public string Name
        {
            get => _club.Name;
            set
            {
                _club.Name = value;
                Validate();
                RaisePropertyChanged("Name");
            }
        }

        [Required(ErrorMessage = "Podaj nazwę miasta z którego jest klub")]
        [RegularExpression(@"^[a-zA-z\ ]*", ErrorMessage = "Użyj tylko liter")]
        public string City
        {
            get => _club.City;
            set
            {
                _club.City = value;
                Validate();
                RaisePropertyChanged("City");
            }
        }

        [Required(ErrorMessage = "Podaj rok założenia klubu")]
        [RegularExpression(@"^[0-9]{4}$", ErrorMessage = "Użyj czterech cyfr")]
        public int EstablishmentYear
        {
            get => _club.EstablishmentYear;
            set
            {
                _club.EstablishmentYear = value;
                Validate();
                RaisePropertyChanged("EstablishmentYear");
            }
        }

        public override bool Equals(object obj)
        {
            var model = obj as ClubViewModel;
            return model != null &&
                   EqualityComparer<IClub>.Default.Equals(_club, model._club) &&
                   EqualityComparer<IClub>.Default.Equals(Club, model.Club) &&
                   Name == model.Name &&
                   City == model.City &&
                   EstablishmentYear == model.EstablishmentYear;
        }

        public override int GetHashCode()
        {
            var hashCode = 1618545312;
            hashCode = hashCode * -1521134295 + EqualityComparer<IClub>.Default.GetHashCode(_club);
            hashCode = hashCode * -1521134295 + EqualityComparer<IClub>.Default.GetHashCode(Club);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(City);
            hashCode = hashCode * -1521134295 + EstablishmentYear.GetHashCode();
            return hashCode;
        }
    }
}
