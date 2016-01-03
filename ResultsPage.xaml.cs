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
    public sealed partial class ResultsPage : November16th.Common.LayoutAwarePage
    {

        List<object> data;

        Collection c;

        string[] s;

        string answer1 = "";
        string answer2 = "";
        string answer3 = "";
        string answer4 = "";
        string answer5 = "";
        string answer6 = "";
        string answer7 = "";
        string answer8 = "";
        string answer9 = "";

        string prefix = "ms-appx:///Images/PicabularyDemo/";
        string postfix = ".jpg";

        public ResultsPage()
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

            s = new string[9];

            data = (List<object>)e.Parameter;
            c = (Collection)data[0];
            s = (string[])data[1];

            answer1 = s[0];
            answer2 = s[1];
            answer3 = s[2];
            answer4 = s[3];
            answer5 = s[4];
            answer6 = s[5];
            answer7 = s[6];
            answer8 = s[7];
            answer9 = s[8];
            

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

            AnswerBox1.Text = answer1;
            AnswerBox2.Text = answer2;
            AnswerBox3.Text = answer3;
            AnswerBox4.Text = answer4;
            AnswerBox5.Text = answer5;
            AnswerBox6.Text = answer6;
            AnswerBox7.Text = answer7;
            AnswerBox8.Text = answer8;
            AnswerBox9.Text = answer9;

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
