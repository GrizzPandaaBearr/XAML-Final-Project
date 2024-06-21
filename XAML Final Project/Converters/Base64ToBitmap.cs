using System.Globalization;
using System.IO;
using System.Windows.Data;
using System.Windows.Media.Imaging;
using System.Drawing;
using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows;

namespace XAML_Final_Project.Converters
{
    internal class Base64ToBitmap : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // app crashes if base64 is incorrect, so lets use try catch block and show alt image if necessary
            // this is a typical error mess "The image has corrupted metadata header."

            string base64String = (string)value;
            byte[] bytes = System.Convert.FromBase64String(base64String);

            try
            {
                using (var stream = new MemoryStream(bytes))
                {
                    return BitmapFrame.Create(stream, BitmapCreateOptions.None, BitmapCacheOption.OnLoad);
                }
            } catch(System.ArgumentException ex)
            {
                Debug.WriteLine("++++ ", ex.Message);
            } catch (Exception ex)
            {
                Debug.WriteLine(message: "---- ", ex.Message);
            }
    
            return DefaultBookImage();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        private BitmapImage DefaultBookImage()
        {
            // admins "test@test.com"
            BitmapImage myBitmapImage = new BitmapImage();
            myBitmapImage.BeginInit();
            myBitmapImage.UriSource = new Uri(@"/Assets/default_book.png", UriKind.RelativeOrAbsolute);
            //myBitmapImage.DecodePixelWidth = 200;
            myBitmapImage.EndInit();

            return myBitmapImage;

        }

        // show pink rect instead
        private BitmapFrame DefaultBitmap()
        {
            byte[] bytes = System.Convert.FromBase64String("iVBORw0KGgoAAAANSUhEUgAAAAoAAAAKCAYAAACNMs+9AAAAFUlEQVR42mP8z8BQz0AEYBxVSF+FABJADveWkH6oAAAAAElFTkSuQmCC");

            using (var stream = new MemoryStream(bytes))
            {
                return BitmapFrame.Create(stream, BitmapCreateOptions.None, BitmapCacheOption.OnLoad);
            }
        }
    }
}