using Mvvm.Services;
using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace XamlBrewer.Uwp.ToolkitPrintHelperSample
{
    public sealed partial class ListPage : Page
    {
        public ListPage()
        {
            this.InitializeComponent();
        }

        private List<Moon> Moons
        {
            get
            {
                return new List<Moon>
                {
                    new Moon { Name = "Callisto", ImagePath = "ms-appx:///Assets/Moons/callisto.png" },
                    new Moon { Name = "Europa", ImagePath = "ms-appx:///Assets/Moons/europa.png" },
                    new Moon { Name = "Ganymede", ImagePath = "ms-appx:///Assets/Moons/ganymede.png" },
                    new Moon { Name = "Not a Moon", ImagePath = "ms-appx:///Assets/Moons/notamoon.png" }
                };
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var service = new PrintService();
            service.Header = new TextBlock { Text = "List of items with page break" };
            service.PageNumbering = PageNumbering.BottomMidle;

            foreach (var moon in Moons)
            {
                // The secret is to NOT use an ItemsControl.
                var cont = new ContentControl();
                cont.ContentTemplate = Resources["MoonTemplate"] as DataTemplate;
                cont.DataContext = moon;
                service.AddPrintContent(cont);
            }

            service.Print();
        }
    }
}
