using System;
using System.Collections.Generic;
using System.Text;

namespace Kowalski.PW_projekt_zaliczeniowy.Interfaces
{
    public interface IClub
    {
        string Name { get; set; }
        string City { get; set; }
        int establishmentYear { get; set; }
    }
}
