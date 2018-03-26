using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Mvvm.Services
{
    public partial class PrintPage : Page
    {
        Grid _printArea;

        public PrintPage(FrameworkElement content, FrameworkElement header = null, FrameworkElement footer = null)
        {
            _printArea = new Grid();
            _printArea.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Auto });
            _printArea.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Star) });
            _printArea.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Auto });
            Content = _printArea;

            AddContent(content);
            Header = header;
            Footer = footer;
        }

        public void AddContent(FrameworkElement content)
        {
            Grid.SetRow(content, 1);
            _printArea.Children.Add(content);
        }

        public FrameworkElement Header
        {
            set
            {
                var header = value.DeepClone();
                Grid.SetRow(header, 0);
                _printArea.Children.Add(header);
            }
        }

        public FrameworkElement Footer
        {
            set
            {
                var footer = value.DeepClone();
                Grid.SetRow(footer, 2);
                _printArea.Children.Add(footer);
            }
        }
    }
}
