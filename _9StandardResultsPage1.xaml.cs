using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
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
    public sealed partial class _9StandardResultsPage : November16th.Common.LayoutAwarePage
    {
        Collection c;

        string prefix = "ms-appx:///Images/PicabularyDemo/";
        string postfix = ".jpg";

        public _9StandardResultsPage()
        {
            this.InitializeComponent();
        }

        protected override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        {
        }

        protected override void SaveState(Dictionary<String, Object> pageState)
        {
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
            BitmapImage src9 = new BitmapImage(new Uri(prefix + c.CollectionPicFileName + "/" + c.CollectionList[8].ItemPicFileName + postfix, UriKind.Absolute));

            Image1.Source = src1;
            Image2.Source = src2;
            Image3.Source = src3;
            Image4.Source = src4;
            Image5.Source = src5;
            Image6.Source = src6;
            Image7.Source = src7;
            Image8.Source = src8;
            Image9.Source = src9;

            TextBlock1.Text = c.CollectionList[0].ItemPicFileName;
            TextBlock2.Text = c.CollectionList[1].ItemPicFileName;
            TextBlock3.Text = c.CollectionList[2].ItemPicFileName;
            TextBlock4.Text = c.CollectionList[3].ItemPicFileName;
            TextBlock5.Text = c.CollectionList[4].ItemPicFileName;
            TextBlock6.Text = c.CollectionList[5].ItemPicFileName;
            TextBlock7.Text = c.CollectionList[6].ItemPicFileName;
            TextBlock8.Text = c.CollectionList[7].ItemPicFileName;
            TextBlock9.Text = c.CollectionList[8].ItemPicFileName;

            AnswerBox1.Text = MyDataList.instance.s9[0];
            AnswerBox2.Text = MyDataList.instance.s9[1];
            AnswerBox3.Text = MyDataList.instance.s9[2];
            AnswerBox4.Text = MyDataList.instance.s9[3];
            AnswerBox5.Text = MyDataList.instance.s9[4];
            AnswerBox6.Text = MyDataList.instance.s9[5];
            AnswerBox7.Text = MyDataList.instance.s9[6];
            AnswerBox8.Text = MyDataList.instance.s9[7];
            AnswerBox9.Text = MyDataList.instance.s9[8];

            if (TextBlock1.Text == AnswerBox1.Text)
            {
                AnswerLight1.Fill = new SolidColorBrush(Colors.Green);
                c.CollectionList[0].TimesRight++;
                c.CollectionList[0].lvl++;
            }
            else
            {
                AnswerLight1.Fill = new SolidColorBrush(Colors.Red);
                c.CollectionList[0].TimesWrong++;
            }
            //
            //
            if (TextBlock2.Text == AnswerBox2.Text)
            {
                AnswerLight2.Fill = new SolidColorBrush(Colors.Green);
                c.CollectionList[1].TimesRight++;
                c.CollectionList[1].lvl++;
            }
            else
            {
                AnswerLight2.Fill = new SolidColorBrush(Colors.Red);
                c.CollectionList[1].TimesWrong++;
            }
            //
            //
            if (TextBlock3.Text == AnswerBox3.Text)
            {
                AnswerLight3.Fill = new SolidColorBrush(Colors.Green);
                c.CollectionList[2].TimesRight++;
                c.CollectionList[2].lvl++;
            }
            else
            {
                AnswerLight3.Fill = new SolidColorBrush(Colors.Red);
                c.CollectionList[2].TimesWrong++;
            }
            //
            //
            if (TextBlock4.Text == AnswerBox4.Text)
            {
                AnswerLight4.Fill = new SolidColorBrush(Colors.Green);
                c.CollectionList[3].TimesRight++;
                c.CollectionList[3].lvl++;
            }
            else
            {
                AnswerLight4.Fill = new SolidColorBrush(Colors.Red);
                c.CollectionList[3].TimesWrong++;
            }
            //
            //
            if (TextBlock5.Text == AnswerBox5.Text)
            {
                AnswerLight5.Fill = new SolidColorBrush(Colors.Green);
                c.CollectionList[4].TimesRight++;
                c.CollectionList[4].lvl++;
            }
            else
            {
                AnswerLight5.Fill = new SolidColorBrush(Colors.Red);
                c.CollectionList[4].TimesWrong++;
            }
            //
            //
            if (TextBlock6.Text == AnswerBox6.Text)
            {
                AnswerLight6.Fill = new SolidColorBrush(Colors.Green);
                c.CollectionList[5].TimesRight++;
                c.CollectionList[5].lvl++;
            }
            else
            {
                AnswerLight6.Fill = new SolidColorBrush(Colors.Red);
                c.CollectionList[5].TimesWrong++;
            }
            //
            //
            if (TextBlock7.Text == AnswerBox7.Text)
            {
                AnswerLight7.Fill = new SolidColorBrush(Colors.Green);
                c.CollectionList[6].TimesRight++;
                c.CollectionList[6].lvl++;
            }
            else
            {
                AnswerLight7.Fill = new SolidColorBrush(Colors.Red);
                c.CollectionList[6].TimesWrong++;
            }
            //
            //
            if (TextBlock8.Text == AnswerBox8.Text)
            {
                AnswerLight8.Fill = new SolidColorBrush(Colors.Green);
                c.CollectionList[7].TimesRight++;
                c.CollectionList[7].lvl++;
            }
            else
            {
                AnswerLight8.Fill = new SolidColorBrush(Colors.Red);
                c.CollectionList[7].TimesWrong++;
            }
            //
            //
            if (TextBlock9.Text == AnswerBox9.Text)
            {
                AnswerLight9.Fill = new SolidColorBrush(Colors.Green);
                c.CollectionList[8].TimesRight++;
                c.CollectionList[8].lvl++;
            }
            else
            {
                AnswerLight9.Fill = new SolidColorBrush(Colors.Red);
                c.CollectionList[8].TimesWrong++;
            }
            //
            //

            NumRightItem1.Text = c.CollectionList[0].TimesRight.ToString();
            NumRightItem2.Text = c.CollectionList[1].TimesRight.ToString();
            NumRightItem3.Text = c.CollectionList[2].TimesRight.ToString();
            NumRightItem4.Text = c.CollectionList[3].TimesRight.ToString();
            NumRightItem5.Text = c.CollectionList[4].TimesRight.ToString();
            NumRightItem6.Text = c.CollectionList[5].TimesRight.ToString();
            NumRightItem7.Text = c.CollectionList[6].TimesRight.ToString();
            NumRightItem8.Text = c.CollectionList[7].TimesRight.ToString();
            NumRightItem9.Text = c.CollectionList[8].TimesRight.ToString();

            NumWrongItem1.Text = c.CollectionList[0].TimesWrong.ToString();
            NumWrongItem2.Text = c.CollectionList[1].TimesWrong.ToString();
            NumWrongItem3.Text = c.CollectionList[2].TimesWrong.ToString();
            NumWrongItem4.Text = c.CollectionList[3].TimesWrong.ToString();
            NumWrongItem5.Text = c.CollectionList[4].TimesWrong.ToString();
            NumWrongItem6.Text = c.CollectionList[5].TimesWrong.ToString();
            NumWrongItem7.Text = c.CollectionList[6].TimesWrong.ToString();
            NumWrongItem8.Text = c.CollectionList[7].TimesWrong.ToString();
            NumWrongItem9.Text = c.CollectionList[8].TimesWrong.ToString();
        }

        private void ToAdvancedLearner(object sender, RoutedEventArgs e)
        {
            if (this.Frame != null)
            {
                this.Frame.Navigate(typeof(AdvancedLearnerPage));
            }
        }

        private void SetReviewOptional(object sender, RoutedEventArgs e)
        {
            c.status = ReviewStatus.OptionalReview;
        }

        private void SetReviewSuggested(object sender, RoutedEventArgs e)
        {
            c.status = ReviewStatus.SuggestedReview;
        }

        private void SetReviewTest(object sender, RoutedEventArgs e)
        {
            c.status = ReviewStatus.LevelTest;
        }

    }
}
