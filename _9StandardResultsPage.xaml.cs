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
    public sealed partial class _9StandardResultsPage2 : November16th.Common.LayoutAwarePage
    {
        Collection c;

        string prefix = "ms-appx:///Images/PicabularyDemo/";
        string postfix = ".jpg";

        public _9StandardResultsPage2()
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

            ResultUC result1 = new ResultUC(src1, c.CollectionList[0].L2, MyDataList.instance.s9[0]);
            ResultUC result2 = new ResultUC(src2, c.CollectionList[1].L2, MyDataList.instance.s9[1]);
            ResultUC result3 = new ResultUC(src3, c.CollectionList[2].L2, MyDataList.instance.s9[2]);
            ResultUC result4 = new ResultUC(src4, c.CollectionList[3].L2, MyDataList.instance.s9[3]);
            ResultUC result5 = new ResultUC(src5, c.CollectionList[4].L2, MyDataList.instance.s9[4]);
            ResultUC result6 = new ResultUC(src6, c.CollectionList[5].L2, MyDataList.instance.s9[5]);
            ResultUC result7 = new ResultUC(src7, c.CollectionList[6].L2, MyDataList.instance.s9[6]);
            ResultUC result8 = new ResultUC(src8, c.CollectionList[7].L2, MyDataList.instance.s9[7]);
            ResultUC result9 = new ResultUC(src9, c.CollectionList[8].L2, MyDataList.instance.s9[8]);


            if (c.CollectionList[0].L2 == MyDataList.instance.s9[0])
            {
                result1.AnswerBorder.Background = new SolidColorBrush(Colors.Green);
                c.CollectionList[0].TimesRight++;
                c.CollectionList[0].lvl++;
            }
            else
            {
                result1.AnswerBorder.Background = new SolidColorBrush(Colors.Red);
                c.CollectionList[0].TimesWrong++;
            }
            //
            //
            if (c.CollectionList[1].L2 == MyDataList.instance.s9[1])
            {
                result2.AnswerBorder.Background = new SolidColorBrush(Colors.Green);
                c.CollectionList[1].TimesRight++;
                c.CollectionList[1].lvl++;
            }
            else
            {
                result2.AnswerBorder.Background = new SolidColorBrush(Colors.Red);
                c.CollectionList[1].TimesWrong++;
            }
            //
            //
            if (c.CollectionList[2].L2 == MyDataList.instance.s9[2])
            {
                result3.AnswerBorder.Background = new SolidColorBrush(Colors.Green);
                c.CollectionList[2].TimesRight++;
                c.CollectionList[2].lvl++;
            }
            else
            {
                result3.AnswerBorder.Background = new SolidColorBrush(Colors.Red);
                c.CollectionList[2].TimesWrong++;
            }
            //
            //
            if (c.CollectionList[3].L2 == MyDataList.instance.s9[3])
            {
                result4.AnswerBorder.Background = new SolidColorBrush(Colors.Green);
                c.CollectionList[3].TimesRight++;
                c.CollectionList[3].lvl++;
            }
            else
            {
                result4.AnswerBorder.Background = new SolidColorBrush(Colors.Red);
                c.CollectionList[3].TimesWrong++;
            }
            //
            //
            if (c.CollectionList[4].L2 == MyDataList.instance.s9[4])
            {
                result5.AnswerBorder.Background = new SolidColorBrush(Colors.Green);
                c.CollectionList[4].TimesRight++;
                c.CollectionList[4].lvl++;
            }
            else
            {
                result5.AnswerBorder.Background = new SolidColorBrush(Colors.Red);
                c.CollectionList[4].TimesWrong++;
            }
            //
            //
            if (c.CollectionList[5].L2 == MyDataList.instance.s9[5])
            {
                result6.AnswerBorder.Background = new SolidColorBrush(Colors.Green);
                c.CollectionList[5].TimesRight++;
                c.CollectionList[5].lvl++;
            }
            else
            {
                result6.AnswerBorder.Background = new SolidColorBrush(Colors.Red);
                c.CollectionList[5].TimesWrong++;
            }
            //
            //
            if (c.CollectionList[6].L2 == MyDataList.instance.s9[6])
            {
                result7.AnswerBorder.Background = new SolidColorBrush(Colors.Green);
                c.CollectionList[6].TimesRight++;
                c.CollectionList[6].lvl++;
            }
            else
            {
                result7.AnswerBorder.Background = new SolidColorBrush(Colors.Red);
                c.CollectionList[6].TimesWrong++;
            }
            //
            //
            if (c.CollectionList[7].L2 == MyDataList.instance.s9[7])
            {
                result8.AnswerBorder.Background = new SolidColorBrush(Colors.Green);
                c.CollectionList[7].TimesRight++;
                c.CollectionList[7].lvl++;
            }
            else
            {
                result8.AnswerBorder.Background = new SolidColorBrush(Colors.Red);
                c.CollectionList[7].TimesWrong++;
            }
            //
            //
            if (c.CollectionList[8].L2 == MyDataList.instance.s9[8])
            {
                result9.AnswerBorder.Background = new SolidColorBrush(Colors.Green);
                c.CollectionList[8].TimesRight++;
                c.CollectionList[8].lvl++;
            }
            else
            {
                result9.AnswerBorder.Background = new SolidColorBrush(Colors.Red);
                c.CollectionList[8].TimesWrong++;
            }
            //
            //

            g1.Children.Add(result1);
            result1.VerticalAlignment = VerticalAlignment.Center;
            result1.HorizontalAlignment = HorizontalAlignment.Center;
            g2.Children.Add(result2);
            result2.VerticalAlignment = VerticalAlignment.Center;
            result2.HorizontalAlignment = HorizontalAlignment.Center;
            g3.Children.Add(result3);
            result3.VerticalAlignment = VerticalAlignment.Center;
            result3.HorizontalAlignment = HorizontalAlignment.Center;
            g4.Children.Add(result4);
            result4.VerticalAlignment = VerticalAlignment.Center;
            result4.HorizontalAlignment = HorizontalAlignment.Center;
            g5.Children.Add(result5);
            result5.VerticalAlignment = VerticalAlignment.Center;
            result5.HorizontalAlignment = HorizontalAlignment.Center;
            g6.Children.Add(result6);
            result6.VerticalAlignment = VerticalAlignment.Center;
            result6.HorizontalAlignment = HorizontalAlignment.Center;
            g7.Children.Add(result7);
            result7.VerticalAlignment = VerticalAlignment.Center;
            result7.HorizontalAlignment = HorizontalAlignment.Center;
            g8.Children.Add(result8);
            result8.VerticalAlignment = VerticalAlignment.Center;
            result8.HorizontalAlignment = HorizontalAlignment.Center;
            g9.Children.Add(result9);
            result9.VerticalAlignment = VerticalAlignment.Center;
            result9.HorizontalAlignment = HorizontalAlignment.Center;
        }

        private void ToAdvancedLearner(object sender, RoutedEventArgs e)
        {
            if (this.Frame != null)
            {
                this.Frame.Navigate(typeof(AdvancedLearnerPage));
            }
        }

    }
}