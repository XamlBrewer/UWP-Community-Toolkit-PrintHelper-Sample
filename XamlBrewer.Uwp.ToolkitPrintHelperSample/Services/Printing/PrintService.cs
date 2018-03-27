using Microsoft.Toolkit.Uwp.Helpers;
using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Mvvm.Services
{
    public class PrintService
    {
        private static Panel _printingContainer;

        private PrintHelper _printHelper;
        private List<FrameworkElement> _content = new List<FrameworkElement>();
        private FrameworkElement _header;
        private FrameworkElement _footer;

        public PrintService()
        {}

        public static Panel PrintingContainer
        {
            set { _printingContainer = value; }
        }

        public FrameworkElement Header
        {
            set { _header = value; }
        }

        public FrameworkElement Footer
        {
            set { _footer = value; }
        }

        public void AddPrintContent(FrameworkElement content)
        {
            _content.Add(content);
        }

        public void Print()
        {
            _printHelper = new PrintHelper(_printingContainer);

            PrintPage.StartPageNumber = 1;
            foreach (var content in _content)
            {
                var page = new PrintPage(content, _header, _footer, PageNumbering.TopRight);
                _printHelper.AddFrameworkElementToPrint(page);
            }

            _printHelper.OnPrintFailed += printHelper_OnPrintFailed;
            _printHelper.OnPrintSucceeded += printHelper_OnPrintSucceeded;
            _printHelper.OnPrintCanceled += printHelper_OnPrintCanceled;

            _printHelper.ShowPrintUIAsync("Print Sample");
        }

        private void printHelper_OnPrintCanceled()
        {
            ReleasePrintHelper();
        }

        private void printHelper_OnPrintSucceeded()
        {
            Toast.ShowInfo("Printed.");
            ReleasePrintHelper();
        }

        private void printHelper_OnPrintFailed()
        {
            Toast.ShowError("Sorry, printing failed.");
            ReleasePrintHelper();
        }

        private void ReleasePrintHelper()

        {
            _printHelper.Dispose();

            //if (!DirectPrintContainer.Children.Contains(PrintableContent))
            //{
            //    DirectPrintContainer.Children.Add(PrintableContent);
            //}
        }
    }
}
