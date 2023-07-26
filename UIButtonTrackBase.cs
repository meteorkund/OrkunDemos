using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows;

namespace OrkunDemos
{
    public abstract class UIButtonTrackBase : Control
    {
        static UIButtonTrackBase()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(UIButtonTrackBase), new FrameworkPropertyMetadata(typeof(UIButtonTrackBase)));

        }

        public string ButtonTrackText
        {
            get { return (string)GetValue(ButtonTrackTextProperty); }
            set { SetValue(ButtonTrackTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ButtonTrackText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ButtonTrackTextProperty =
            DependencyProperty.Register(nameof(ButtonTrackText), typeof(string), typeof(UIButtonTrackBase), new PropertyMetadata(default(string)));

        public Brush ButtonTrackTextColor
        {
            get { return (Brush)GetValue(ButtonTrackTextColorProperty); }
            set { SetValue(ButtonTrackTextColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ButtonTrackText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ButtonTrackTextColorProperty =
            DependencyProperty.Register(nameof(ButtonTrackTextColor), typeof(Brush), typeof(UIButtonTrackBase), new PropertyMetadata(default(string)));




        public string ButtonTrackLabelText
        {
            get { return (string)GetValue(ButtonTrackLabelTextProperty); }
            set { SetValue(ButtonTrackLabelTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ButtonTrackLabelText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ButtonTrackLabelTextProperty =
            DependencyProperty.Register(nameof(ButtonTrackLabelText), typeof(string), typeof(UIButtonTrackBase), new PropertyMetadata(default(string)));





        public Brush ButtonTrackLabelColor
        {
            get { return (Brush)GetValue(ButtonTrackLabelColorProperty); }
            set { SetValue(ButtonTrackLabelColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ButtonTrackLabelColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ButtonTrackLabelColorProperty =
            DependencyProperty.Register(nameof(ButtonTrackLabelColor), typeof(Brush), typeof(UIButtonTrackBase), new PropertyMetadata(default(Brush)));



        public Brush ButtonBackground
        {
            get { return (Brush)GetValue(ButtonBackgroundProperty); }
            set { SetValue(ButtonBackgroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ButtonBackground.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ButtonBackgroundProperty =
            DependencyProperty.Register(nameof(ButtonBackground), typeof(Brush), typeof(UIButtonTrackBase), new PropertyMetadata(default(Brush)));

        public Visibility ButtonTrackLabelVisibility
        {
            get { return (Visibility)GetValue(ButtonTrackLabelVisibilityProperty); }
            set { SetValue(ButtonTrackLabelVisibilityProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ButtonTrackLabelVisibility.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ButtonTrackLabelVisibilityProperty =
            DependencyProperty.Register(nameof(ButtonTrackLabelVisibility), typeof(Visibility), typeof(UIButtonTrackBase), new PropertyMetadata(default(Visibility)));





        public double Position
        {
            get { return (double)GetValue(PositionProperty); }
            set { SetValue(PositionProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Position.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PositionProperty =
            DependencyProperty.Register(nameof(Position), typeof(double), typeof(UIButtonTrackBase), new PropertyMetadata(default(double)));



        public double MaxLimit
        {
            get { return (double)GetValue(MaxLimitProperty); }
            set { SetValue(MaxLimitProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MaxLimit.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MaxLimitProperty =
            DependencyProperty.Register(nameof(MaxLimit), typeof(double), typeof(UIButtonTrackBase), new PropertyMetadata(default(double)));



        public double MinLimit
        {
            get { return (double)GetValue(MinLimitProperty); }
            set { SetValue(MinLimitProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MinLimit.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MinLimitProperty =
            DependencyProperty.Register(nameof(MinLimit), typeof(double), typeof(UIButtonTrackBase), new PropertyMetadata(default(double)));





    }
}
