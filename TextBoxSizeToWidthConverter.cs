using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Forms;

namespace OrkunDemos
{
    public class TextBoxSizeToWidthConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Font segoeUI = new Font("Segoe UI", 12);
            Size size = TextRenderer.MeasureText(value.ToString(), segoeUI);
            if (size.Width < 50)
                return 50;
            return size.Width;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
