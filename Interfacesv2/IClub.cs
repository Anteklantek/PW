using System;
using System.Collections.Generic;
using System.Text;

namespace Kowalski.PW_projekt_zaliczeniowy.Interfacesv2
{
    public interface IClub
    {
        string Name { get; set; }
        string City { get; set; }
        int EstablishmentYear { get; set; }

        string ToString { get; }


    }
}
