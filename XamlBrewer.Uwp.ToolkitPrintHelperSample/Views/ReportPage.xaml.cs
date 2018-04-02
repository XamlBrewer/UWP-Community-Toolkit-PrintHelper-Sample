using Mvvm.Services;
using System.Collections.Generic;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace XamlBrewer.Uwp.ToolkitPrintHelperSample
{
    public sealed partial class ReportPage : Page
    {
        public ReportPage()
        {
            this.InitializeComponent();
        }

        public List<Moon> Moons
        {
            get
            {
                return Moon.Moons;
            }
        }

        public Moon SelectedMoon
        {
            get
            {
                return Moon.Moons.Single(m => m.Name == "Mimas");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var service = new PrintService();
            service.Header = new TextBlock { Text = "Dashboard to Report" };
            service.PageNumbering = PageNumbering.None;

            var cont = new ContentControl();
            cont.ContentTemplate = Resources["ReportTemplate"] as DataTemplate;
            cont.DataContext = this;
            service.AddPrintContent(cont);

            service.Print();
        }
    }
}
