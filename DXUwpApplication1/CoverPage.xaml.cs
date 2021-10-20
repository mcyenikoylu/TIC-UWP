using DevExpress.UI.Xaml.Layout;

namespace DXUwpApplication1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CoverPage : DXPage
    {
        public CoverPage()
        {
            this.InitializeComponent();

            // Set supported inking device types.
            myInkCanvas.InkPresenter.InputDeviceTypes =
                Windows.UI.Core.CoreInputDeviceTypes.Mouse |
                Windows.UI.Core.CoreInputDeviceTypes.Pen;
        }

        private void CoverPageFileNotesSave_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }

        private void BtnCoverPageNew_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }

        private void BtnCoverPagePDF_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }
    }
}
