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
    public sealed partial class LearnerPage : November16th.Common.LayoutAwarePage
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
        FlipViewItem flip9 = new FlipViewItem();

        string answer1 = "";
        string answer2 = "";
        string answer3 = "";
        string answer4 = "";
        string answer5 = "";
        string answer6 = "";
        string answer7 = "";
        string answer8 = "";
        string answer9 = "";

        public LearnerPage()
        {
            this.InitializeComponent();
            //string answer1 = "";
            //string answer2 = "";
            //string answer3 = "";
            //string answer4 = "";
            //string answer5 = "";
            //string answer6 = "";
            //string answer7 = "";
            //string answer8 = "";
            //string answer9 = "";
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

            c = (Collection)e.Parameter;

            BitmapImage src1 = new BitmapImage(new Uri(prefix + c.CollectionPicFileName + "/" + c.CollectionList[0].ItemPicFileName + postfix, UriKind.Absolute));
            BitmapImage src2 = new BitmapImage(new Uri(prefix + c.CollectionPicFileName + "/" + c.CollectionList[1].ItemPicFileName + postfix, UriKind.Absolute));
            BitmapImage src3 = new BitmapImage(new Uri(prefix + c.CollectionPicFileName + "/" + c.CollectionList[2].ItemPicFileName + postfix, UriKind.Absolute));
            BitmapImage src4 = new BitmapImage(new Uri(prefix + c.CollectionPicFileName + "/" + c.CollectionList[3].ItemPicFileName + postfix, UriKind.Absolute));
            BitmapImage src5 = new BitmapImage(new Uri(prefix + c.CollectionPicFileName + "/" + c.CollectionList[4].ItemPicFileName + postfix, UriKind.Absolute));
            BitmapImage src6 = new BitmapImage(new Uri(prefix + c.CollectionPicFileName + "/" + c.CollectionList[5].ItemPicFileName + postfix, UriKind.Absolute));
            BitmapImage src7 = new BitmapImage(new Uri(prefix + c.CollectionPicFileName + "/" + c.CollectionList[6].ItemPicFileName + postfix, UriKind.Absolute));
            BitmapImage src8 = new BitmapImage(new Uri(prefix + c.CollectionPicFileName + "/" + c.CollectionList[7].ItemPicFileName + postfix, UriKind.Absolute));
            BitmapImage src9 = new BitmapImage(new Uri(prefix + c.CollectionPicFileName + "/" + c.CollectionList[8].ItemPicFileName + postfix, UriKind.Absolute));

            //FlipViewItem flip1 = new FlipViewItem();
            //FlipViewItem flip2 = new FlipViewItem();
            //FlipViewItem flip3 = new FlipViewItem();
            //FlipViewItem flip4 = new FlipViewItem();
            //FlipViewItem flip5 = new FlipViewItem();
            //FlipViewItem flip6 = new FlipViewItem();
            //FlipViewItem flip7 = new FlipViewItem();
            //FlipViewItem flip8 = new FlipViewItem();
            //FlipViewItem flip9 = new FlipViewItem();

            ImageBrush brush1 = new ImageBrush();
            ImageBrush brush2 = new ImageBrush();
            ImageBrush brush3 = new ImageBrush();
            ImageBrush brush4 = new ImageBrush();
            ImageBrush brush5 = new ImageBrush();
            ImageBrush brush6 = new ImageBrush();
            ImageBrush brush7 = new ImageBrush();
            ImageBrush brush8 = new ImageBrush();
            ImageBrush brush9 = new ImageBrush();

            brush1.ImageSource = src1;
            brush2.ImageSource = src2;
            brush3.ImageSource = src3;
            brush4.ImageSource = src4;
            brush5.ImageSource = src5;
            brush6.ImageSource = src6;
            brush7.ImageSource = src7;
            brush8.ImageSource = src8;
            brush9.ImageSource = src9;

            flip1.Background = brush1;
            flip2.Background = brush2;
            flip3.Background = brush3;
            flip4.Background = brush4;
            flip5.Background = brush5;
            flip6.Background = brush6;
            flip7.Background = brush7;
            flip8.Background = brush8;
            flip9.Background = brush9;

            FlipViewer.Items.Add(flip1);
            FlipViewer.Items.Add(flip2);
            FlipViewer.Items.Add(flip3);
            FlipViewer.Items.Add(flip4);
            FlipViewer.Items.Add(flip5);
            FlipViewer.Items.Add(flip6);
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

        private void ToAdvancedLearner(object sender, RoutedEventArgs e)
        {
            if (this.Frame != null)
            {
                string[] s = { answer1, answer2, answer3, answer4, answer5, answer6, answer7, answer8, answer9 };
                
                List<object> data = new List<object>();
                data.Add(c);
                data.Add(s);
                this.Frame.Navigate(typeof(ResultsPage), data);
            }
        }

        private void FlipViewerSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FlipViewer.SelectedItem == flip1)
            {
                AnswerTextBox.Text = answer1;
            }
            else if (FlipViewer.SelectedItem == flip2)
            {
                AnswerTextBox.Text = answer2;
            }
            else if (FlipViewer.SelectedItem == flip3)
            {
                AnswerTextBox.Text = answer3;
            }
            else if (FlipViewer.SelectedItem == flip4)
            {
                AnswerTextBox.Text = answer4;
            }
            else if (FlipViewer.SelectedItem == flip5)
            {
                AnswerTextBox.Text = answer5;
            }
            else if (FlipViewer.SelectedItem == flip6)
            {
                AnswerTextBox.Text = answer6;
            }
            else if (FlipViewer.SelectedItem == flip7)
            {
                AnswerTextBox.Text = answer7;
            }
            else if (FlipViewer.SelectedItem == flip8)
            {
                AnswerTextBox.Text = answer8;
            }
            else if (FlipViewer.SelectedItem == flip9)
            {
                AnswerTextBox.Text = answer9;
            }

        }

        private void AnswerTextBoxTextChanged(object sender, TextChangedEventArgs e)
        {
            if (FlipViewer.SelectedItem == flip1)
            {
                answer1 = AnswerTextBox.Text;
            }
            else if (FlipViewer.SelectedItem == flip2)
            {
                answer2 = AnswerTextBox.Text;
            }
            else if (FlipViewer.SelectedItem == flip3)
            {
                answer3 = AnswerTextBox.Text;
            }
            else if (FlipViewer.SelectedItem == flip4)
            {
                answer4 = AnswerTextBox.Text;
            }
            else if (FlipViewer.SelectedItem == flip5)
            {
                answer5 = AnswerTextBox.Text;
            }
            else if (FlipViewer.SelectedItem == flip6)
            {
                answer6 = AnswerTextBox.Text;
            }
            else if (FlipViewer.SelectedItem == flip7)
            {
                answer7 = AnswerTextBox.Text;
            }
            else if (FlipViewer.SelectedItem == flip8)
            {
                answer8 = AnswerTextBox.Text;
            }
            else if (FlipViewer.SelectedItem == flip9)
            {
                answer9 = AnswerTextBox.Text;
            }
        }
    }
}
