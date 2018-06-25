using Kowalski.PW_projekt_zaliczeniowy.Interfacesv2;
using Kowalski.PW_projekt_zaliczeniowy.PW_projekt_zaliczeniowy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Kowalski.PW_projekt_zaliczeniowy.PW_projekt_zaliczeniowy
{
    public class Converter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return ((ClubViewModel)value).Club;
        }
    }
}
