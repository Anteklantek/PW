using Kowalski.PW_projekt_zaliczeniowy.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Kowalski.PW_projekt_zaliczeniowy.Interfaces
{
    public interface IPlayer
    {
        string Name { get; set; }
        string Surname { get; set; }
        Position Position { get; set; }
    }
}
