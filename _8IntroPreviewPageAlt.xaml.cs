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
    public sealed partial class _8IntroPreviewPageAlt : November16th.Common.LayoutAwarePage
    {
        Collection c;

        string prefix = "ms-appx:///Images/PicabularyDemo/";
        string postfix = ".jpg";

        public _8IntroPreviewPageAlt()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            c = MyDataList.instance.CollectionList.Find(co => co.CollectionID == (int)e.Parameter);

            MyDataList.instance.s9[0] = "";
            MyDataList.instance.s9[1] = "";
            MyDataList.instance.s9[2] = "";
            MyDataList.instance.s9[3] = "";
            MyDataList.instance.s9[4] = "";
            MyDataList.instance.s9[5] = "";
            MyDataList.instance.s9[6] = "";
            MyDataList.instance.s9[7] = "";
            MyDataList.instance.s9[8] = "";

            BitmapImage src1 = new BitmapImage(new Uri(prefix + c.CollectionPicFileName + "/" + c.CollectionList[0].ItemPicFileName + postfix, UriKind.Absolute));
            BitmapImage src2 = new BitmapImage(new Uri(prefix + c.CollectionPicFileName + "/" + c.CollectionList[1].ItemPicFileName + postfix, UriKind.Absolute));
            BitmapImage src3 = new BitmapImage(new Uri(prefix + c.CollectionPicFileName + "/" + c.CollectionList[2].ItemPicFileName + postfix, UriKind.Absolute));
            BitmapImage src4 = new BitmapImage(new Uri(prefix + c.CollectionPicFileName + "/" + c.CollectionList[3].ItemPicFileName + postfix, UriKind.Absolute));
            BitmapImage src5 = new BitmapImage(new Uri(prefix + c.CollectionPicFileName + "/" + c.CollectionList[4].ItemPicFileName + postfix, UriKind.Absolute));
            BitmapImage src6 = new BitmapImage(new Uri(prefix + c.CollectionPicFileName + "/" + c.CollectionList[5].ItemPicFileName + postfix, UriKind.Absolute));
            BitmapImage src7 = new BitmapImage(new Uri(prefix + c.CollectionPicFileName + "/" + c.CollectionList[6].ItemPicFileName + postfix, UriKind.Absolute));
            BitmapImage src8 = new BitmapImage(new Uri(prefix + c.CollectionPicFileName + "/" + c.CollectionList[7].ItemPicFileName + postfix, UriKind.Absolute));

            Image1.Source = src1;
            Image2.Source = src2;
            Image3.Source = src3;
            Image4.Source = src4;
            Image5.Source = src5;
            Image6.Source = src6;
            Image7.Source = src7;
            Image8.Source = src8;

            TextBlock1.Text = c.CollectionList[0].ItemPicFileName;
            TextBlock2.Text = c.CollectionList[1].ItemPicFileName;
            TextBlock3.Text = c.CollectionList[2].ItemPicFileName;
            TextBlock4.Text = c.CollectionList[3].ItemPicFileName;
            TextBlock5.Text = c.CollectionList[4].ItemPicFileName;
            TextBlock6.Text = c.CollectionList[5].ItemPicFileName;
            TextBlock7.Text = c.CollectionList[6].ItemPicFileName;
            TextBlock8.Text = c.CollectionList[7].ItemPicFileName;

            if (c.status == ReviewStatus.OptionalReview)
            {
                BitmapImage opt = new BitmapImage(new Uri(prefix + "Backgrounds/BeginnerOptional" + postfix, UriKind.Absolute));
                ImageBrush bg = new ImageBrush();
                bg.ImageSource = opt;
                bg.Opacity = 0.5;
                MainGrid.Background = bg;
            }
            //if (c.status == ReviewStatus.SuggestedReview)
            //{
            //    BitmapImage opt = new BitmapImage(new Uri(prefix + "Backgrounds/BeginnerSuggested" + postfix, UriKind.Absolute));
            //    ImageBrush bg = new ImageBrush();
            //    bg.ImageSource = opt;
            //    bg.Opacity = 0.1;
            //    MainGrid.Background = bg;

            //}
            //if (c.status == ReviewStatus.LevelTest)
            //{
            //    BitmapImage opt = new BitmapImage(new Uri(prefix + "Backgrounds/BeginnerTest" + postfix, UriKind.Absolute));
            //    ImageBrush bg = new ImageBrush();
            //    bg.ImageSource = opt;
            //    bg.Opacity = 0.1;
            //    MainGrid.Background = bg;
            //} 

        }

        protected override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        {
        }

        protected override void SaveState(Dictionary<String, Object> pageState)
        {
        }

        private void ToIntroLearnerPart1(object sender, RoutedEventArgs e)
        {
            if (this.Frame != null)
            {
                this.Frame.Navigate(typeof(_8IntroLearnerPagePart1), c.CollectionID);
            }
        }
    }
}
