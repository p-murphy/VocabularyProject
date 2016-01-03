using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace November16th
{
    public sealed partial class ResultUC : UserControl
    {
        public ResultUC(BitmapSource src, string txt, string ans)
        {
            Image i = new Image();
            i.Source = src;

            this.InitializeComponent();
            this.FrameGrid.Children.Add(i);
            Grid.SetColumn(i, 0);

            this.CorrectAnswerTextBlock.Text = txt;
            this.YourAnswerTextBlock.Text = ans;

        }
    }
}
