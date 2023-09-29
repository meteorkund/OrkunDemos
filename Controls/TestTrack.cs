using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace OrkunDemos.Controls
{
    public class TestTrack : Control
    {

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            var button = GetTemplateChild("PART_Button") as UIButtonTrack;
            if (button != null)
            {
                button.MouseMove += Button_MouseMove;
                button.PreviewMouseLeftButtonUp += Button_PreviewMouseLeftButtonUp;
                button.PreviewMouseLeftButtonDown += Button_PreviewMouseLeftButtonDown;
            }
        }

        private void Button_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            IsClick = true;
        }

        private void Button_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            IsClick = false;
        }

        private bool IsClick = false;
        private void Button_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed && IsClick == true)
            {
                var buttonC = sender as UIButtonTrack;
                var parent = VisualTreeHelper.GetParent(buttonC) as UIElement;
                Point relativePoint = buttonC.PointToScreen(new Point(0, 0));
                buttonC.ButtonTrackText = relativePoint.Y.ToString();
                buttonC.CaptureMouse();
            }
        }


    }
}
