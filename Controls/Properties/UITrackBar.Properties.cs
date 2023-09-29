using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using OrkunDemos.Enums;

namespace OrkunDemos.Controls
{
    public partial class UITrackBar : Canvas
    {

        public double Max
        {
            get { return (double)GetValue(MaxProperty); }
            set { SetValue(MaxProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Max.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MaxProperty =
            DependencyProperty.Register("Max", typeof(double), typeof(UITrackBar), new PropertyMetadata(default(double)));

        public RulerPositionValues RulerPosition
        {
            get { return (RulerPositionValues)GetValue(RulerPositionProperty); }
            set { SetValue(RulerPositionProperty, value); }
        }

        public static readonly DependencyProperty RulerPositionProperty =
            DependencyProperty.Register("RulerPosition", typeof(RulerPositionValues), typeof(UITrackBar), new PropertyMetadata(RulerPositionValues.Left));

        public double Min
        {
            get { return (double)GetValue(MinProperty); }
            set { SetValue(MinProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Min.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MinProperty =
            DependencyProperty.Register("Min", typeof(double), typeof(UITrackBar), new PropertyMetadata(0.0));



        public int Total
        {
            get { return (int)GetValue(TotalProperty); }
            set { SetValue(TotalProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Total.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TotalProperty =
            DependencyProperty.Register("Total", typeof(int), typeof(UITrackBar), new PropertyMetadata(default(int)));


        public double TextNoneValue
        {
            get { return (double)GetValue(TextNoneValueProperty); }
            set { SetValue(TextNoneValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TextNoneValue.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextNoneValueProperty =
            DependencyProperty.Register(nameof(TextNoneValue), typeof(double), typeof(UITrackBar), new PropertyMetadata(default(double)));


        public Brush LinesColor
        {
            get { return (Brush)GetValue(LinesColorProperty); }
            set { SetValue(LinesColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for LinesColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LinesColorProperty =
            DependencyProperty.Register("LinesColor", typeof(Brush), typeof(UITrackBar), new PropertyMetadata(default(Brush)));


        public Brush TextColor
        {
            get { return (Brush)GetValue(TextColorProperty); }
            set { SetValue(TextColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TextColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextColorProperty =
            DependencyProperty.Register("TextColor", typeof(Brush), typeof(UITrackBar), new PropertyMetadata(default(Brush)));


        public Brush TextBackgroundColor
        {
            get { return (Brush)GetValue(TextBackgroundColorProperty); }
            set { SetValue(TextBackgroundColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TextBackgroundColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextBackgroundColorProperty =
            DependencyProperty.Register("TextBackgroundColor", typeof(Brush), typeof(UITrackBar), new PropertyMetadata(default(Brush)));



        public double TextOpacity
        {
            get { return (double)GetValue(TextOpacityProperty); }
            set { SetValue(TextOpacityProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TextOpacity.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextOpacityProperty =
            DependencyProperty.Register("TextOpacity", typeof(double), typeof(UITrackBar), new PropertyMetadata(1.0));





        public double TextHeight
        {
            get { return (double)GetValue(TextHeightProperty); }
            set { SetValue(TextHeightProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TextHeight.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextHeightProperty =
            DependencyProperty.Register("TextHeight", typeof(double), typeof(UITrackBar), new PropertyMetadata(10.0));




        public double TextWidth
        {
            get { return (double)GetValue(TextWidthProperty); }
            set { SetValue(TextWidthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TextWidth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextWidthProperty =
            DependencyProperty.Register("TextWidth", typeof(double), typeof(UITrackBar), new PropertyMetadata(10.0));



        public double TextFontSize
        {
            get { return (double)GetValue(TextFontSizeProperty); }
            set { SetValue(TextFontSizeProperty, value);}
        }

        // Using a DependencyProperty as the backing store for TextFontSize.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextFontSizeProperty =
            DependencyProperty.Register(nameof(TextFontSize), typeof(double), typeof(UITrackBar), new PropertyMetadata(10.0));




    }
}
