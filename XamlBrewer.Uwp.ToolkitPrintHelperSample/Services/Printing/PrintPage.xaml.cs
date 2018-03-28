using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace Mvvm.Services
{
    public partial class PrintPage : Page
    {
        static int _pageNumber = 0;
        Grid _printArea;
        private PageNumbering _pageNumbering;

        public PrintPage(FrameworkElement content, FrameworkElement header = null, FrameworkElement footer = null, PageNumbering pageNumbering = PageNumbering.None)
        {
            _printArea = new Grid();
            //// _printArea.Background = new SolidColorBrush(Color.FromArgb(128, 128, 128, 128)); // TEMP, just for testing
            _printArea.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Auto });
            _printArea.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Star) });
            _printArea.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Auto });
            _printArea.Children.Add(new Canvas() { Width = 10000 }); // Horizontally stretches the Grid.

            Content = _printArea;

            PageNumbering = pageNumbering;
            AddContent(content);
            Header = header;
            Footer = footer;
        }

        public static int StartPageNumber
        { set { _pageNumber = value - 1; } }

        public void AddContent(FrameworkElement content)
        {
            Grid.SetRow(content, 1);
            _printArea.Children.Add(content);

            if (PageNumbering != PageNumbering.None)
            {
                _pageNumber += 1;
                var pageNumberText = new TextBlock() { Text = _pageNumber.ToString() };

                switch (PageNumbering)
                {
                    case PageNumbering.None:
                        break;
                    case PageNumbering.TopLeft:
                        Grid.SetRow(pageNumberText, 0);
                        pageNumberText.Margin = new Thickness(0, 0, 0, 20);
                        _printArea.Children.Add(pageNumberText);
                        break;
                    case PageNumbering.TopMiddle:
                        Grid.SetRow(pageNumberText, 0);
                        pageNumberText.Margin = new Thickness(0, 0, 0, 20);
                        pageNumberText.HorizontalAlignment = HorizontalAlignment.Stretch;
                        pageNumberText.HorizontalTextAlignment = TextAlignment.Center;
                        _printArea.Children.Add(pageNumberText);
                        break;
                    case PageNumbering.TopRight:
                        Grid.SetRow(pageNumberText, 0);
                        Grid.SetColumn(pageNumberText, 1);
                        pageNumberText.Margin = new Thickness(0, 0, 0, 20);
                        pageNumberText.HorizontalAlignment = HorizontalAlignment.Stretch;
                        pageNumberText.HorizontalTextAlignment = TextAlignment.Right;
                        _printArea.Children.Add(pageNumberText);

                        break;
                    case PageNumbering.BottomLeft:
                        Grid.SetRow(pageNumberText, 2);
                        pageNumberText.Margin = new Thickness(0, 20, 0, 0);
                        _printArea.Children.Add(pageNumberText);
                        break;
                    case PageNumbering.BottomMidle:
                        Grid.SetRow(pageNumberText, 2);
                        pageNumberText.Margin = new Thickness(0, 20, 0, 0);
                        pageNumberText.HorizontalAlignment = HorizontalAlignment.Stretch;
                        pageNumberText.HorizontalTextAlignment = TextAlignment.Center;
                        _printArea.Children.Add(pageNumberText);
                        break;
                    case PageNumbering.BottomRight:
                        Grid.SetRow(pageNumberText, 2);
                        pageNumberText.Margin = new Thickness(0, 20, 0, 0);
                        _printArea.Children.Add(pageNumberText);
                        break;
                    default:
                        break;
                }
            }
        }

        public FrameworkElement Header
        {
            set
            {
                if (value != null)
                {
                    var header = value.DeepClone();
                    Grid.SetRow(header, 0);
                    _printArea.Children.Add(header);
                }
            }
        }

        public FrameworkElement Footer
        {
            set
            {
                if (value != null)
                {
                    var footer = value.DeepClone();
                    Grid.SetRow(footer, 2);
                    _printArea.Children.Add(footer);
                }
            }
        }

        public PageNumbering PageNumbering
        {
            get { return _pageNumbering; }
            set { _pageNumbering = value; }
        }
    }
}
