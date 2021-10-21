using DevExpress.UI.Xaml.Controls.Internal.Pdf;
using DevExpress.UI.Xaml.Layout;
using System;
using Windows.Storage;

namespace DXUwpApplication1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PageViewer : DXPage
    {
        public PageViewer()
        {
            this.InitializeComponent();
        }
        private async void PdfViewer_Loaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            var document = await StorageFile.GetFileFromPathAsync(DataAccess._PageViewerFilePath);
            pdfViewer.DocumentSource = await PdfDocumentHelper.LoadPdfContainer(document);
        }
    }
}
