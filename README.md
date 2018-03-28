# UWP-Community-Toolkit-PrintHelper-Sample
Demonstrates some advanced print features on top of the UWP Community Toolkit PrintHelper:

* adding page header and footer,
* adding page numbers,
* printing a list with all items on a separate page,
* ...

Core classes are
* [PrintService](https://github.com/XamlBrewer/UWP-Community-Toolkit-PrintHelper-Sample/blob/master/XamlBrewer.Uwp.ToolkitPrintHelperSample/Services/Printing/PrintService.cs), which acts as a wrapper around [PrintHelper](https://github.com/Microsoft/UWPCommunityToolkit/tree/master/Microsoft.Toolkit.Uwp/Helpers/PrintHelper) and plays its Service role in an MVVM architecture, and
* [PrintPage](https://github.com/XamlBrewer/UWP-Community-Toolkit-PrintHelper-Sample/blob/master/XamlBrewer.Uwp.ToolkitPrintHelperSample/Services/Printing/PrintPage.xaml.cs), a more intelligent print page that knows about headers, footers, page numbering, and maybe more.

![ScreenShot](Assets/HeaderFooterPageNumbers.png?raw=true "Screenshot")
