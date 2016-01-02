using System;
using System.Collections.Generic;
using System.IO;
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

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace November16th
{
    public sealed partial class _9IntroLearnerPagePart1 : November16th.Common.LayoutAwarePage
    {
        Collection c;

        string prefix = "ms-appx:///Images/PicabularyDemo/";
        string postfix = ".jpg";

        FlipViewItem flip1 = new FlipViewItem();
        FlipViewItem flip2 = new FlipViewItem();
        FlipViewItem flip3 = new FlipViewItem();


        public _9IntroLearnerPagePart1()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="navigationParameter">The parameter value passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested.
        /// </param>
        /// <param name="pageState">A dictionary of state preserved by this page during an earlier
        /// session.  This will be null the first time a page is visited.</param>

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            c = MyDataList.instance.CollectionList.Find(co => co.CollectionID == (int)e.Parameter);

            BitmapImage src1 = new BitmapImage(new Uri(prefix + c.CollectionPicFileName + "/" + c.CollectionList[0].ItemPicFileName + postfix, UriKind.Absolute));
            BitmapImage src2 = new BitmapImage(new Uri(prefix + c.CollectionPicFileName + "/" + c.CollectionList[1].ItemPicFileName + postfix, UriKind.Absolute));
            BitmapImage src3 = new BitmapImage(new Uri(prefix + c.CollectionPicFileName + "/" + c.CollectionList[2].ItemPicFileName + postfix, UriKind.Absolute));

            ImageBrush brush1 = new ImageBrush();
            ImageBrush brush2 = new ImageBrush();
            ImageBrush brush3 = new ImageBrush();

            brush1.ImageSource = src1;
            brush2.ImageSource = src2;
            brush3.ImageSource = src3;

            flip1.Background = brush1;
            flip2.Background = brush2;
            flip3.Background = brush3;

            FlipViewer.Items.Add(flip1);
            FlipViewer.Items.Add(flip2);
            FlipViewer.Items.Add(flip3);
        }
        
        protected override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        {
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="pageState">An empty dictionary to be populated with serializable state.</param>
        protected override void SaveState(Dictionary<String, Object> pageState)
        {
        }

        private void FlipViewerSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FlipViewer.SelectedItem == flip1)
            {
                AnswerTextBox.Text = MyDataList.instance.s9[0];
                L2TextBox.Text = c.CollectionList[0].L2;
            }
            else if (FlipViewer.SelectedItem == flip2)
            {
                AnswerTextBox.Text = MyDataList.instance.s9[1];
                L2TextBox.Text = c.CollectionList[1].L2;
            }
            else if (FlipViewer.SelectedItem == flip3)
            {
                AnswerTextBox.Text = MyDataList.instance.s9[2];
                L2TextBox.Text = c.CollectionList[2].L2;
            }
        }

        private void AnswerTextBoxTextChanged(object sender, TextChangedEventArgs e)
        {
            if (FlipViewer.SelectedItem == flip1)
            {
                MyDataList.instance.s9[0] = AnswerTextBox.Text;
            }
            else if (FlipViewer.SelectedItem == flip2)
            {
                MyDataList.instance.s9[1] = AnswerTextBox.Text;
            }
            else if (FlipViewer.SelectedItem == flip3)
            {
                MyDataList.instance.s9[2] = AnswerTextBox.Text;
            }
        }

        private void ToPart2(object sender, RoutedEventArgs e)
        {

            if ((MyDataList.instance.s9[0] != c.CollectionList[0].L2) ||
                (MyDataList.instance.s9[1] != c.CollectionList[1].L2) ||
                (MyDataList.instance.s9[2] != c.CollectionList[2].L2))
            {
                MessageTextBox.Text = "Oops! Please review answers for mistakes before proceeding.";
            }
            else
            {
                if (this.Frame != null)
                {
                    this.Frame.Navigate(typeof(_9IntroLearnerPagePart2), c.CollectionID);
                }
            }
        }
    }
}
