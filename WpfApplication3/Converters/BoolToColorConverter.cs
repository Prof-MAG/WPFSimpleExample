using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace WpfApplication3.Converters
{
    class BoolToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var v = (bool)value;
            if(v)
            {
                return new SolidColorBrush(Colors.Red);
            }
            else
            {
                
                return new SolidColorBrush(Colors.Blue);
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
