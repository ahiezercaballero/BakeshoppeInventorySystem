using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace BakeshoppeInventorySystem.ValueConverters
{
    public class BooleanToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool isTrue = (parameter as string) == "true";
            //bool condition = (value as int?) > 0;
            if (targetType != typeof(Visibility)) throw new InvalidOperationException("The target must be a Visibility!");
            if (value == null) return isTrue ? Visibility.Collapsed : Visibility.Visible;
            return isTrue ?  Visibility.Visible : Visibility.Collapsed;
            
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
