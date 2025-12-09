using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace WPF_Story_08_TriggerAndStyle
{
    public class Converters
    {
    }
    public class NameToLogoConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string logoUri = string.Format(@"Resources/Logos/{0} Logo.jpg", (string)value);
            return new BitmapImage(new Uri(logoUri,UriKind.Relative));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    public class NameToPhotoConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string photoUri = string.Format(@"Resources/Images/{0} Photo.jpg", (string)value);
            return new BitmapImage(new Uri(photoUri,UriKind.Relative));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}
