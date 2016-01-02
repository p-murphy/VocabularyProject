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
    public sealed partial class _9IntroLearnerPagePart3 : November16th.Common.LayoutAwarePage
    {
        Collection c;

        string prefix = "ms-appx:///Images/PicabularyDemo/";
        string postfix = ".jpg";

        FlipViewItem flip7 = new FlipViewItem();
        FlipViewItem flip8 = new FlipViewItem();
        FlipViewItem flip9 = new FlipViewItem();

        public _9IntroLearnerPagePart3()
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

            BitmapImage src7 = new BitmapImage(new Uri(prefix + c.CollectionPicFileName + "/" + c.CollectionList[6].ItemPicFileName + postfix, UriKind.Absolute));
            BitmapImage src8 = new BitmapImage(new Uri(prefix + c.CollectionPicFileName + "/" + c.CollectionList[7].ItemPicFileName + postfix, UriKind.Absolute));
            BitmapImage src9 = new BitmapImage(new Uri(prefix + c.CollectionPicFileName + "/" + c.CollectionList[8].ItemPicFileName + postfix, UriKind.Absolute));

            ImageBrush brush7 = new ImageBrush();
            ImageBrush brush8 = new ImageBrush();
            ImageBrush brush9 = new ImageBrush();

            brush7.ImageSource = src7;
            brush8.ImageSource = src8;
            brush9.ImageSource = src9;

            flip7.Background = brush7;
            flip8.Background = brush8;
            flip9.Background = brush9;

            FlipViewer.Items.Add(flip7);
            FlipViewer.Items.Add(flip8);
            FlipViewer.Items.Add(flip9);

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
            if (FlipViewer.SelectedItem == flip7)
            {
                AnswerTextBox.Text = MyDataList.instance.s9[6];
                L2TextBox.Text = c.CollectionList[6].L2;
            }
            else if (FlipViewer.SelectedItem == flip8)
            {
                AnswerTextBox.Text = MyDataList.instance.s9[7];
                L2TextBox.Text = c.CollectionList[7].L2;
            }
            else if (FlipViewer.SelectedItem == flip9)
            {
                AnswerTextBox.Text = MyDataList.instance.s9[8];
                L2TextBox.Text = c.CollectionList[8].L2;
            }

        }

        private void AnswerTextBoxTextChanged(object sender, TextChangedEventArgs e)
        {
            if (FlipViewer.SelectedItem == flip7)
            {
                MyDataList.instance.s9[6] = AnswerTextBox.Text;
            }
            else if (FlipViewer.SelectedItem == flip8)
            {
                MyDataList.instance.s9[7] = AnswerTextBox.Text;
            }
            else if (FlipViewer.SelectedItem == flip9)
            {
                MyDataList.instance.s9[8] = AnswerTextBox.Text;
            }
        }

        private void ToIntroResults(object sender, RoutedEventArgs e)
        {

            if ((MyDataList.instance.s9[6] != c.CollectionList[6].L2) ||
                (MyDataList.instance.s9[7] != c.CollectionList[7].L2) ||
                (MyDataList.instance.s9[8] != c.CollectionList[8].L2))
            {
                MessageTextBox.Text = "Oops! Please review answers for mistakes before proceeding.";
            }
            else
            {
                if (this.Frame != null)
                {
                    this.Frame.Navigate(typeof(_9IntroResultsPage), c.CollectionID);
                }
            }
        }
    }
}
