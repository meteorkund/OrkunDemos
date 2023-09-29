using System;
using System.Windows;
using System.Windows.Controls;

namespace OrkunDemos.Controls
{
    public partial class UIButtonTrack : Control, IDisposable
    {
        static UIButtonTrack()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(UIButtonTrack), new FrameworkPropertyMetadata(typeof(UIButtonTrack)));
        }

        public void Dispose()
        {
            
        }
    }
}
