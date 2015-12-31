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

    public sealed partial class _8IntroLearnerPagePart2 : November16th.Common.LayoutAwarePage
    {
        Collection c;

        string prefix = "ms-appx:///Images/PicabularyDemo/";
        string postfix = ".jpg";

        FlipViewItem flip5 = new FlipViewItem();
        FlipViewItem flip6 = new FlipViewItem();
        FlipViewItem flip7 = new FlipViewItem();
        FlipViewItem flip8 = new FlipViewItem();

        public _8IntroLearnerPagePart2()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            c = MyDataList.instance.CollectionList.Find(co => co.CollectionID == (int)e.Parameter);

            BitmapImage src5 = new BitmapImage(new Uri(prefix + c.CollectionPicFileName + "/" + c.CollectionList[4].ItemPicFileName + postfix, UriKind.Absolute));
            BitmapImage src6 = new BitmapImage(new Uri(prefix + c.CollectionPicFileName + "/" + c.CollectionList[5].ItemPicFileName + postfix, UriKind.Absolute));
            BitmapImage src7 = new BitmapImage(new Uri(prefix + c.CollectionPicFileName + "/" + c.CollectionList[6].ItemPicFileName + postfix, UriKind.Absolute));
            BitmapImage src8 = new BitmapImage(new Uri(prefix + c.CollectionPicFileName + "/" + c.CollectionList[7].ItemPicFileName + postfix, UriKind.Absolute));

            ImageBrush brush5 = new ImageBrush();
            ImageBrush brush6 = new ImageBrush();
            ImageBrush brush7 = new ImageBrush();
            ImageBrush brush8 = new ImageBrush();

            brush5.ImageSource = src5;
            brush6.ImageSource = src6;
            brush7.ImageSource = src7;
            brush8.ImageSource = src8;

            flip5.Background = brush5;
            flip6.Background = brush6;
            flip7.Background = brush7;
            flip8.Background = brush8;

            FlipViewer.Items.Add(flip5);
            FlipViewer.Items.Add(flip6);
            FlipViewer.Items.Add(flip7);
            FlipViewer.Items.Add(flip8);
        }

        protected override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        {
        }

        protected override void SaveState(Dictionary<String, Object> pageState)
        {
        }

        private void FlipViewerSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FlipViewer.SelectedItem == flip5)
            {
                AnswerTextBox.Text = MyDataList.instance.s9[4];
                L2TextBox.Text = c.CollectionList[4].L2;
            }
            else if (FlipViewer.SelectedItem == flip6)
            {
                AnswerTextBox.Text = MyDataList.instance.s9[5];
                L2TextBox.Text = c.CollectionList[5].L2;
            }
            else if (FlipViewer.SelectedItem == flip7)
            {
                AnswerTextBox.Text = MyDataList.instance.s9[6];
                L2TextBox.Text = c.CollectionList[6].L2;
            }
            else if (FlipViewer.SelectedItem == flip8)
            {
                AnswerTextBox.Text = MyDataList.instance.s9[7];
                L2TextBox.Text = c.CollectionList[7].L2;
            }
        }

        private void AnswerTextBoxTextChanged(object sender, TextChangedEventArgs e)
        {
            if (FlipViewer.SelectedItem == flip5)
            {
                MyDataList.instance.s9[4] = AnswerTextBox.Text;
            }
            else if (FlipViewer.SelectedItem == flip6)
            {
                MyDataList.instance.s9[5] = AnswerTextBox.Text;
            }
            else if (FlipViewer.SelectedItem == flip7)
            {
                MyDataList.instance.s9[6] = AnswerTextBox.Text;
            }
            else if (FlipViewer.SelectedItem == flip8)
            {
                MyDataList.instance.s9[7] = AnswerTextBox.Text;
            }
        }

        private void ToPart2(object sender, RoutedEventArgs e)
        {
            if ((MyDataList.instance.s9[4] != c.CollectionList[4].L2) ||
                (MyDataList.instance.s9[5] != c.CollectionList[5].L2) ||
                (MyDataList.instance.s9[6] != c.CollectionList[6].L2) ||
                (MyDataList.instance.s9[7] != c.CollectionList[7].L2))
            {
                MessageTextBox.Text = "Oops! Please review answers for mistakes before proceeding.";
            }
            else
            {
                if (this.Frame != null)
                {
                    this.Frame.Navigate(typeof(_8IntroResultsPage), c.CollectionID);
                }
            }
        }

    }
}
