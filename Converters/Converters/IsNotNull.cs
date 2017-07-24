using System;
using System.Globalization;
using Xamarin.Forms;

namespace Converters
{
    public class IsNotNull : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (targetType != typeof(bool))
                throw new ArgumentException($"Incorrect target type {targetType} for IsNotNull Converter. Expected type is {typeof(bool)}");
            return value != null;
        } 

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
