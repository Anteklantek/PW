using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kowalski.PW_projekt_zaliczeniowy.Interfacesv2
{
    public interface IDAO
    {
        IEnumerable<IPlayer> GetAllPlayers();

        IEnumerable<IClub> GetAllClubs();

        IClub GetClubToEdit();

        IPlayer GetPlayerToEdit();

    }
}
