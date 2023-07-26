using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows;
using System.ComponentModel;
using System.Resources;
using System.Security.Cryptography.Xml;
using System.Data;
using System.Linq;
using System.Xml.Linq;

namespace OrkunDemos
{
    public class UITrackBar : UITrackBarBase
    {
        private readonly List<UIButtonTrack> _trackBarButtons = new List<UIButtonTrack>();
        public IReadOnlyList<UIButtonTrack> TrackBarButtons { get => _trackBarButtons; }

        public UITrackBar()
        {
            Loaded += UIStrcb_Loaded;

            Initialize();

        }

        private void Initialize()
        {

        }

        private void UIStrcb_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            if (RulerPosition == RulerPositionValues.Top)
                DrawRuler(SystemParameters.PrimaryScreenWidth, 0, SetTickPosition, SetTickTextPositionHorizontal);

            if (RulerPosition == RulerPositionValues.Bottom)
                DrawRuler(SystemParameters.PrimaryScreenWidth, Height, SetTickPosition, SetTickTextPositionHorizontal);

            if (RulerPosition == RulerPositionValues.Left)
                DrawRuler(Max, 0, SetTickPositionSwapped, SetTickTextPositionVertical);

            if (RulerPosition == RulerPositionValues.Right)
                DrawRuler(SystemParameters.PrimaryScreenHeight, Width, SetTickPositionSwapped, SetTickTextPositionVertical);
        }



        #region DrawingRuler

        private void DrawRuler(double pixelCount, double tickOffset,
    Action<Line, double, double, double, double> setTickPosition,
    Action<TextBlock, int> setTickTextPosition)
        {
            var isLeftTop = RulerPosition == RulerPositionValues.Left || RulerPosition == RulerPositionValues.Top;



            var newButton = new UIButtonTrack
            {
                Margin = new Thickness(5, 0, 0, 0),
                ButtonTrackTextColor = Brushes.Red,
                Foreground = Brushes.Red,
                ButtonTrackLabelText = "OPEN",
                Background = Brushes.Blue,
                BorderThickness = new Thickness(1),
                BorderBrush = Brushes.Black,
            };

            SetLeft(newButton, 25);
            SetTop(newButton, 0);

            newButton.ButtonTrackText = "0";
            newButton.MouseDown += item_MouseDown;
            newButton.MouseUp += item_MouseUp;
            newButton.MouseMove += item_MouseMove;

            Children.Add(newButton);

            for (var position = 0; position < pixelCount + 2; position += 2)
            {
                var length = GetLength(position);

                var tick = new Line
                {
                    Stroke = LinesColor,
                    StrokeThickness = 1.0
                };

                setTickPosition(tick, position - 1, position - 1, tickOffset - length, tickOffset + length);

                if (isLeftTop && position >= 0 && position % 100 == 0)
                {
                    var tickText = new TextBlock { Text = position.ToString("0") };
                    tickText.Foreground = TextColor;
                    tickText.Opacity = TextOpacity;
                    Children.Add(tickText);
                    tickText.Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));

                    setTickTextPosition(tickText, position - 1);
                }

                Children.Add(tick);
            }
        }


        private static void SetTickTextPositionVertical(TextBlock tickText, int position)
        {
            var bottom = position - tickText.DesiredSize.Height / 2;
            SetLeft(tickText, 12);
            SetBottom(tickText, bottom);
        }

        private static void SetTickTextPositionHorizontal(TextBlock tickText, int position)
        {
            var left = position - tickText.DesiredSize.Width / 2;
            SetBottom(tickText, 12);
            SetLeft(tickText, left);
        }

        private static void SetTickPosition(Line tick, double x1, double x2, double y1, double y2)
        {
            tick.X1 = x1;
            tick.X2 = x2;
            tick.Y1 = y1;
            tick.Y2 = y2;
        }

        public void SetTickPositionSwapped(Line tick, double x1, double x2, double y1, double y2)
        {
            SetTickPosition(tick, y1, y2, x1, x2);
        }

        private static int GetLength(int pos)
        {
            var length = 4;

            if (pos % 10 == 0)
                length = 8;

            if (pos % 50 == 0)
                length = 12;

            return length;
        }

        public Brush ConvertHexToBrush(string hexCode)
        {
            if (string.IsNullOrEmpty(hexCode) || hexCode.Length < 6)
                return Brushes.Transparent;

            if (hexCode[0] == '#')
                hexCode = hexCode.Substring(1);

            byte a = 255;
            byte r = byte.Parse(hexCode.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
            byte g = byte.Parse(hexCode.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
            byte b = byte.Parse(hexCode.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);

            Brush brush = new SolidColorBrush(Color.FromArgb(a, r, g, b));
            return brush;
        }

        #endregion




        bool IsClick = false;




        private void item_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var _ButtonTrack = sender as UIButtonTrack;
            _ButtonTrack?.CaptureMouse();

        }
        private void item_MouseUp(object sender, MouseButtonEventArgs e)
        {
            var _ButtonTrack = sender as UIButtonTrack;
            _ButtonTrack?.ReleaseMouseCapture();

        }
        private void item_MouseMove(object sender, MouseEventArgs e)
        {
            var _ButtonTrack = sender as UIButtonTrack;
            if (_ButtonTrack != null)
            {
                if (_ButtonTrack.IsMouseCaptured)
                {
                    if (e.Source is UIButtonTrack buttonTrack)
                    {
                        Point point = e.GetPosition(this);
                        var absY = Math.Abs(point.Y - 800);
                        var x = (point.Y - buttonTrack.ActualHeight / 2);
                        if (point.Y <= 800 && point.Y >=-1)
                        {
                            //prew pos < current todo.
                            SetTop(_ButtonTrack, x);
                            var currentPos = Convert.ToInt32(Math.Abs(800 - x));
                            _ButtonTrack.ButtonTrackText = ((int)absY).ToString();
                            buttonTrack.CaptureMouse();
                        }
                    }
                }
            }
        }

    }
}
