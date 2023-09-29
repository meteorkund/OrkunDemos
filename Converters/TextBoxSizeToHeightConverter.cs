using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Forms;

namespace OrkunDemos.Converters
{
    public class TextBoxSizeToHeightConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Font segoeUI = new Font("Segoe UI", 12);
            Size size = TextRenderer.MeasureText(value.ToString(), segoeUI);
            if (size.Height < 20)
                return 30;
            return size.Height * 2;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
