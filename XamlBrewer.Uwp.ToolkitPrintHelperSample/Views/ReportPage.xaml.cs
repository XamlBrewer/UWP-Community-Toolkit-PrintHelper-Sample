using Mvvm.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace XamlBrewer.Uwp.ToolkitPrintHelperSample
{
    public sealed partial class ReportPage : Page
    {
        public ReportPage()
        {
            this.InitializeComponent();
        }

        private List<Moon> Moons
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
