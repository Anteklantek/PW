using Kowalski.PW_projekt_zaliczeniowy.BussinesLogicv2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kowalski.PW_projekt_zaliczeniowy.PW_projekt_zaliczeniowy
{
    class PlayerListViewModel : ListViewModel<PlayerViewModel>
    {
        protected override void Initialize()
        {
            var players = BusinessLogic.Instance.GetAllPlayers();
            foreach (var player in players)
            {
                Items.Add(new PlayerViewModel(player));
            }
            SetUpNewClubToAdd();
        }

        protected override void SetUpNewClubToAdd()
        {
            var playerToEdit = BusinessLogic.Instance.GetPlayerToEdit();
            playerToEdit.Name = "Edit name before adding...";
            playerToEdit.Surname = "Edit surname before adding...";
            EditedItem = new PlayerViewModel(playerToEdit);
        }
    }
}
