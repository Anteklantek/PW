using Kowalski.PW_projekt_zaliczeniowy.BussinesLogicv2;
using Kowalski.PW_projekt_zaliczeniowy.Interfacesv2;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Kowalski.PW_projekt_zaliczeniowy.PW_projekt_zaliczeniowy
{
    class ClubListViewModel : ListViewModel<ClubViewModel>
    {

        protected override void Initialize()
        {
            var clubs = BusinessLogic.Instance.GetAllClubs();
            foreach (var club in clubs)
            {
                Items.Add(new ClubViewModel(club));
            }
            SetUpNewClubToAdd();
        }

        protected override void SetUpNewClubToAdd()
        {
            var clubToEdit = BusinessLogic.Instance.GetClubToEdit();
            clubToEdit.Name = "Edit name before adding...";
            clubToEdit.City = "Edit city before adding...";
            clubToEdit.EstablishmentYear = 0000;
            EditedItem = new ClubViewModel(clubToEdit);
        }
    }
}
