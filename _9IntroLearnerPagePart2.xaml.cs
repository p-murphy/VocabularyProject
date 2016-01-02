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
    public sealed partial class _9IntroLearnerPagePart2 : November16th.Common.LayoutAwarePage
    {
        Collection c;

        string prefix = "ms-appx:///Images/PicabularyDemo/";
        string postfix = ".jpg";
 
        FlipViewItem flip4 = new FlipViewItem();
        FlipViewItem flip5 = new FlipViewItem();
        FlipViewItem flip6 = new FlipViewItem();

        public _9IntroLearnerPagePart2()
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

            Answer1TextBox.Text = MyDataList.instance.s9[0];
            Answer2TextBox.Text = MyDataList.instance.s9[1];
            Answer3TextBox.Text = MyDataList.instance.s9[2];

            BitmapImage src4 = new BitmapImage(new Uri(prefix + c.CollectionPicFileName + "/" + c.CollectionList[3].ItemPicFileName + postfix, UriKind.Absolute));
            BitmapImage src5 = new BitmapImage(new Uri(prefix + c.CollectionPicFileName + "/" + c.CollectionList[4].ItemPicFileName + postfix, UriKind.Absolute));
            BitmapImage src6 = new BitmapImage(new Uri(prefix + c.CollectionPicFileName + "/" + c.CollectionList[5].ItemPicFileName + postfix, UriKind.Absolute));

            ImageBrush brush4 = new ImageBrush();
            ImageBrush brush5 = new ImageBrush();
            ImageBrush brush6 = new ImageBrush();

            brush4.ImageSource = src4;
            brush5.ImageSource = src5;
            brush6.ImageSource = src6;

            flip4.Background = brush4;
            flip5.Background = brush5;
            flip6.Background = brush6;

            FlipViewer.Items.Add(flip4);
            FlipViewer.Items.Add(flip5);
            FlipViewer.Items.Add(flip6);
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
            if (FlipViewer.SelectedItem == flip4)
            {
                AnswerTextBox.Text = MyDataList.instance.s9[3];
                L2TextBox.Text = c.CollectionList[3].L2;
            }
            else if (FlipViewer.SelectedItem == flip5)
            {
                AnswerTextBox.Text = MyDataList.instance.s9[4];
                L2TextBox.Text = c.CollectionList[4].L2;
            }
            else if (FlipViewer.SelectedItem == flip6)
            {
                AnswerTextBox.Text = MyDataList.instance.s9[5];
                L2TextBox.Text = c.CollectionList[5].L2;
            }

        }

        private void AnswerTextBoxTextChanged(object sender, TextChangedEventArgs e)
        {

            if (FlipViewer.SelectedItem == flip4)
            {
                MyDataList.instance.s9[3] = AnswerTextBox.Text;
            }
            else if (FlipViewer.SelectedItem == flip5)
            {
                MyDataList.instance.s9[4] = AnswerTextBox.Text;
            }
            else if (FlipViewer.SelectedItem == flip6)
            {
                MyDataList.instance.s9[5] = AnswerTextBox.Text;
            }
        }

        private void ToPart3(object sender, RoutedEventArgs e)
        {

            if ((MyDataList.instance.s9[3] != c.CollectionList[3].L2) ||
                (MyDataList.instance.s9[4] != c.CollectionList[4].L2) ||
                (MyDataList.instance.s9[5] != c.CollectionList[5].L2))
            {
                MessageTextBox.Text = "Oops! Please review answers for mistakes before proceeding.";
            }
            else
            {
                if (this.Frame != null)
                {
                    this.Frame.Navigate(typeof(_9IntroLearnerPagePart3), c.CollectionID);
                }
            }
        }
    }
}
