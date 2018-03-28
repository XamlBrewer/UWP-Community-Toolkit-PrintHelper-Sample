using Mvvm.Services;
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace XamlBrewer.Uwp.ToolkitPrintHelperSample
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            var service = new PrintService();

            // Define Header, Footer, and Page Numbering.
            service.Header = new TextBlock() { Text = "Header", Margin = new Thickness(0, 0, 0, 20) };
            service.Footer = new TextBlock() { Text = "Footer", Margin = new Thickness(0, 20, 0, 0) };
            service.PageNumbering = PageNumbering.TopRight;

            // Add three pages.
            service.AddPrintContent(new TextBlock() { Text = "Hello World!" });
            service.AddPrintContent(new Image() { Source = new BitmapImage(new Uri("ms-appx:///Assets/world.png")) });
            service.AddPrintContent(new TextBlock() { Text = "Goodbye World!" });

            service.Print();
        }
    }
}
