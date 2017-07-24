using System;
using System.Globalization;
using Xamarin.Forms;

namespace Converters
{
    public class InvertBool : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (targetType != typeof(bool))
                throw new ArgumentException($"Incorrect target type {targetType} for IsNotNull Converter. Expected type is {typeof(bool)}");
            switch (value)
            {
                case bool boolValue:
                    return !boolValue;
                case null:
                    return null;
                default:
                    throw new ArgumentException($"Invorrect value type {value.GetType()} for InvertBool Converter. Expected type is {typeof(bool)}");
            };
        } 

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
