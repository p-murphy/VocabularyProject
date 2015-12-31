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
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class _8StandardLearnerPage : November16th.Common.LayoutAwarePage
    {
        Collection c;
        string prefix = "ms-appx:///Images/PicabularyDemo/";
        string postfix = ".jpg";

        FlipViewItem flip1 = new FlipViewItem();
        FlipViewItem flip2 = new FlipViewItem();
        FlipViewItem flip3 = new FlipViewItem();
        FlipViewItem flip4 = new FlipViewItem();
        FlipViewItem flip5 = new FlipViewItem();
        FlipViewItem flip6 = new FlipViewItem();
        FlipViewItem flip7 = new FlipViewItem();
        FlipViewItem flip8 = new FlipViewItem();

        public _8StandardLearnerPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            c = MyDataList.instance.CollectionList.Find(co => co.CollectionID == (int)e.Parameter);

            BitmapImage src1 = new BitmapImage(new Uri(prefix + c.CollectionPicFileName + "/" + c.CollectionList[0].ItemPicFileName + postfix, UriKind.Absolute));
            BitmapImage src2 = new BitmapImage(new Uri(prefix + c.CollectionPicFileName + "/" + c.CollectionList[1].ItemPicFileName + postfix, UriKind.Absolute));
            BitmapImage src3 = new BitmapImage(new Uri(prefix + c.CollectionPicFileName + "/" + c.CollectionList[2].ItemPicFileName + postfix, UriKind.Absolute));
            BitmapImage src4 = new BitmapImage(new Uri(prefix + c.CollectionPicFileName + "/" + c.CollectionList[3].ItemPicFileName + postfix, UriKind.Absolute));
            BitmapImage src5 = new BitmapImage(new Uri(prefix + c.CollectionPicFileName + "/" + c.CollectionList[4].ItemPicFileName + postfix, UriKind.Absolute));
            BitmapImage src6 = new BitmapImage(new Uri(prefix + c.CollectionPicFileName + "/" + c.CollectionList[5].ItemPicFileName + postfix, UriKind.Absolute));
            BitmapImage src7 = new BitmapImage(new Uri(prefix + c.CollectionPicFileName + "/" + c.CollectionList[6].ItemPicFileName + postfix, UriKind.Absolute));
            BitmapImage src8 = new BitmapImage(new Uri(prefix + c.CollectionPicFileName + "/" + c.CollectionList[7].ItemPicFileName + postfix, UriKind.Absolute));

            ImageBrush brush1 = new ImageBrush();
            ImageBrush brush2 = new ImageBrush();
            ImageBrush brush3 = new ImageBrush();
            ImageBrush brush4 = new ImageBrush();
            ImageBrush brush5 = new ImageBrush();
            ImageBrush brush6 = new ImageBrush();
            ImageBrush brush7 = new ImageBrush();
            ImageBrush brush8 = new ImageBrush();

            brush1.ImageSource = src1;
            brush2.ImageSource = src2;
            brush3.ImageSource = src3;
            brush4.ImageSource = src4;
            brush5.ImageSource = src5;
            brush6.ImageSource = src6;
            brush7.ImageSource = src7;
            brush8.ImageSource = src8;

            flip1.Background = brush1;
            flip2.Background = brush2;
            flip3.Background = brush3;
            flip4.Background = brush4;
            flip5.Background = brush5;
            flip6.Background = brush6;
            flip7.Background = brush7;
            flip8.Background = brush8;

            FlipViewer.Items.Add(flip1);
            FlipViewer.Items.Add(flip2);
            FlipViewer.Items.Add(flip3);
            FlipViewer.Items.Add(flip4);
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

        private void ToStandardResults(object sender, RoutedEventArgs e)
        {
            if (this.Frame != null)
            {
                this.Frame.Navigate(typeof(_8StandardResultsPage), c.CollectionID);
            }
        }

        private void FlipViewerSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FlipViewer.SelectedItem == flip1)
            {
                AnswerTextBox.Text = MyDataList.instance.s9[0];
            }
            else if (FlipViewer.SelectedItem == flip2)
            {
                AnswerTextBox.Text = MyDataList.instance.s9[1];
            }
            else if (FlipViewer.SelectedItem == flip3)
            {
                AnswerTextBox.Text = MyDataList.instance.s9[2];
            }
            if (FlipViewer.SelectedItem == flip4)
            {
                AnswerTextBox.Text = MyDataList.instance.s9[3];
            }
            else if (FlipViewer.SelectedItem == flip5)
            {
                AnswerTextBox.Text = MyDataList.instance.s9[4];
            }
            else if (FlipViewer.SelectedItem == flip6)
            {
                AnswerTextBox.Text = MyDataList.instance.s9[5];
            }
            if (FlipViewer.SelectedItem == flip7)
            {
                AnswerTextBox.Text = MyDataList.instance.s9[6];
            }
            else if (FlipViewer.SelectedItem == flip8)
            {
                AnswerTextBox.Text = MyDataList.instance.s9[7];
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
            if (FlipViewer.SelectedItem == flip7)
            {
                MyDataList.instance.s9[6] = AnswerTextBox.Text;
            }
            else if (FlipViewer.SelectedItem == flip8)
            {
                MyDataList.instance.s9[7] = AnswerTextBox.Text;
            }
        }
    }
}
