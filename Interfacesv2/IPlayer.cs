using Kowalski.PW_projekt_zaliczeniowy.Corev2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Kowalski.PW_projekt_zaliczeniowy.Interfacesv2
{

    public interface IPlayer
    {
        string Name { get; set; }
        string Surname { get; set; }
        Position Position { get; set; }

        IClub Club { get; set; }

        string ToString { get; }
    }
}
