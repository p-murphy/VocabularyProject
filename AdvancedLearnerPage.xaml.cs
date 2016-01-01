using System;
using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace November16th
{
    /// <summary>
    /// Code behind that corresponds to AdvancedLearnerPage.xaml
    /// Patrick Murphy, Nov 16th
    /// Last updated August 12th
    /// </summary>
    public sealed partial class AdvancedLearnerPage : November16th.Common.LayoutAwarePage
    {
        Collection c;      // Holds information for ItemName display to be loaded at runtime

        public AdvancedLearnerPage()
        {
            this.InitializeComponent();

            // Set background image
            BitmapImage opt = new BitmapImage(makeAbsoluteUri("Backgrounds/AdvancedLearner"));
            ImageBrush bg = new ImageBrush();
            bg.ImageSource = opt;
            bg.Opacity = 0.4;
            MainGrid.Background = bg;

            // Fills scroll viewer at runtime.
            for (int i = 0; i < 5; i++)
            {
                setupLayoutFrames();
            }

            checkScheduler();
        }


        // Reviews word albums that are ready for review, according to various conditions
        private void checkScheduler()
        {
            // If something is sitting in the queue, compare when it is to be shown with the time it is now
            if(Scheduler.instance.ScheduleQueue.Count > 0)
            {
                Appointment first = Scheduler.instance.ScheduleQueue[0];
                TimeSpan diff = first.DatTim - DateTime.Now;

                // If the album at the top of the scheduled queue is ready to be shown, add it to the page at the top
                if(diff.TotalSeconds < 0)
                {
                    BitmapImage src = new BitmapImage(makeAbsoluteUri(first.C.CollectionPicFileName));
                    Polaroid pol = new Polaroid(src, this, first.C);
                    pol.CollectionTileImage.Name = first.C.CollectionPicFileName;

                    this.SuggestedGrid.Children.Add(pol);
                    OptionalReviewTextBlock.Text = "Suggested Review";
                    OptionalReviewTextBlock.Visibility = Visibility.Visible;                   
                }
            }
        }

        protected override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        {
        }

        protected override void SaveState(Dictionary<String, Object> pageState)
        {
        }

        // Used in setupLayoutFrames to build Album Collections
        private void addPolaroid(Page page, Collection col)
        {

            BitmapImage src = new BitmapImage(makeAbsoluteUri(col.CollectionPicFileName));
            Polaroid pol = new Polaroid(src, page, col);
            pol.CollectionTileImage.Name = col.CollectionPicFileName;

            AdvancedLearnerStackPanel.Children.Add(pol);
        }

        // Minifies the process of creating an Absolute URI
        private Uri makeAbsoluteUri(string core)
        {
            string prefix = "ms-appx:///Images/PicabularyDemo/";
            string postfix = ".jpg";

            return new Uri(prefix + core + postfix, UriKind.Absolute);
        }


        // Fills the scroll viewer with Albums (an "Album" is a 3x3 frame that holds conceptually related items)
        private void setupLayoutFrames2()
        {
            CollectionFrame frame1 = new CollectionFrame();

            // Both x and y can hold the values 1, 2, or 3, and correspond to the position of a Polaroid element
            // in an Album
            int x = 1;
            int y = 1;

            // Creates 9 Polaroids and places them into a slot in the Album
            for (int i = 0; i < 9; i++)
            {
                BitmapImage src1 = new BitmapImage(makeAbsoluteUri(MyDataList.instance.CollectionList[i].CollectionPicFileName));
                Polaroid pol1 = new Polaroid(src1, this, MyDataList.instance.CollectionList[i]);
                pol1.CollectionTileImage.Name = MyDataList.instance.CollectionList[i].CollectionPicFileName;

                frame1.CollectionFrameButtonGrid.Children.Add(pol1);
                Grid.SetColumn(pol1, x);
                Grid.SetRow(pol1, y);

                y++;

                if (y == 4)
                {
                    y = 1;
                    x++;
                }
            }

            // Adds Album to scroll viewer
            AdvancedLearnerStackPanel.Children.Add(frame1);
        }

        // Fills the scroll viewer with Albums
        private void setupLayoutFrames()
        {
            CollectionFrame frame1 = new CollectionFrame();

            BitmapImage src1 = new BitmapImage(makeAbsoluteUri(MyDataList.instance.CollectionList[2].CollectionPicFileName));
            Polaroid pol1 = new Polaroid(src1, this, MyDataList.instance.CollectionList[2]);
            pol1.CollectionTileImage.Name = MyDataList.instance.CollectionList[2].CollectionPicFileName;

            frame1.CollectionFrameButtonGrid.Children.Add(pol1);
            Grid.SetColumn(pol1, 1);
            Grid.SetRow(pol1, 1);
            //
            BitmapImage src2 = new BitmapImage(makeAbsoluteUri(MyDataList.instance.CollectionList[1].CollectionPicFileName));
            Polaroid pol2 = new Polaroid(src2, this, MyDataList.instance.CollectionList[1]);
            pol2.CollectionTileImage.Name = MyDataList.instance.CollectionList[1].CollectionPicFileName;

            frame1.CollectionFrameButtonGrid.Children.Add(pol2);
            Grid.SetColumn(pol2, 1);
            Grid.SetRow(pol2, 2);
            //
            BitmapImage src3 = new BitmapImage(makeAbsoluteUri(MyDataList.instance.CollectionList[5].CollectionPicFileName));
            Polaroid pol3 = new Polaroid(src3, this, MyDataList.instance.CollectionList[5]);
            pol3.CollectionTileImage.Name = MyDataList.instance.CollectionList[5].CollectionPicFileName;

            frame1.CollectionFrameButtonGrid.Children.Add(pol3);
            Grid.SetColumn(pol3, 1);
            Grid.SetRow(pol3, 3);
            //
            //////////////////////
            //
            BitmapImage src4 = new BitmapImage(makeAbsoluteUri(MyDataList.instance.CollectionList[0].CollectionPicFileName));
            Polaroid pol4 = new Polaroid(src4, this, MyDataList.instance.CollectionList[0]);
            pol4.CollectionTileImage.Name = MyDataList.instance.CollectionList[0].CollectionPicFileName;

            frame1.CollectionFrameButtonGrid.Children.Add(pol4);
            Grid.SetColumn(pol4, 2);
            Grid.SetRow(pol4, 1);
            //
            BitmapImage src5 = new BitmapImage(makeAbsoluteUri(MyDataList.instance.CollectionList[4].CollectionPicFileName));
            Polaroid pol5 = new Polaroid(src5, this, MyDataList.instance.CollectionList[4]);
            pol5.CollectionTileImage.Name = MyDataList.instance.CollectionList[4].CollectionPicFileName;

            frame1.CollectionFrameButtonGrid.Children.Add(pol5);
            Grid.SetColumn(pol5, 2);
            Grid.SetRow(pol5, 2);
            //
            BitmapImage src6 = new BitmapImage(makeAbsoluteUri(MyDataList.instance.CollectionList[6].CollectionPicFileName));
            Polaroid pol6 = new Polaroid(src6, this, MyDataList.instance.CollectionList[6]);
            pol6.CollectionTileImage.Name = MyDataList.instance.CollectionList[6].CollectionPicFileName;

            frame1.CollectionFrameButtonGrid.Children.Add(pol6);
            Grid.SetColumn(pol6, 2);
            Grid.SetRow(pol6, 3);
            //
            /////////////
            //
            BitmapImage src7 = new BitmapImage(makeAbsoluteUri(MyDataList.instance.CollectionList[3].CollectionPicFileName));
            Polaroid pol7 = new Polaroid(src7, this, MyDataList.instance.CollectionList[3]);
            pol7.CollectionTileImage.Name = MyDataList.instance.CollectionList[3].CollectionPicFileName;

            frame1.CollectionFrameButtonGrid.Children.Add(pol7);
            Grid.SetColumn(pol7, 3);
            Grid.SetRow(pol7, 1);
            //
            BitmapImage src8 = new BitmapImage(makeAbsoluteUri(MyDataList.instance.CollectionList[7].CollectionPicFileName));
            Polaroid pol8 = new Polaroid(src8, this, MyDataList.instance.CollectionList[7]);
            pol8.CollectionTileImage.Name = MyDataList.instance.CollectionList[7].CollectionPicFileName;

            frame1.CollectionFrameButtonGrid.Children.Add(pol8);
            Grid.SetColumn(pol8, 3);
            Grid.SetRow(pol8, 2);
            //
            BitmapImage src9 = new BitmapImage(makeAbsoluteUri(MyDataList.instance.CollectionList[8].CollectionPicFileName));
            Polaroid pol9 = new Polaroid(src9, this, MyDataList.instance.CollectionList[8]);
            pol9.CollectionTileImage.Name = MyDataList.instance.CollectionList[8].CollectionPicFileName;

            frame1.CollectionFrameButtonGrid.Children.Add(pol9);
            Grid.SetColumn(pol9, 3);
            Grid.SetRow(pol9, 3);
            //
            /////////////
            //

            AdvancedLearnerStackPanel.Children.Add(frame1);

        }

        // Displays the names of the items in the collection when the collection is hovered over
        private void CollectionNameTextBoxChanged(object sender, TextChangedEventArgs e)
        {
            c = MyDataList.instance.CollectionList.Find(co => co.CollectionPicFileName == CollectionNameTextBox.Text);

            // If the mouse is not currently hovering over a collection, set them to be blank,
            // else, set them to the data found corresponding in the CollectionList
            // whether there are 8 or 9 items in the collection
            if (this.CollectionNameTextBox.Text == "")
            {
                this.ItemName1.Text = "";
                this.ItemName2.Text = "";
                this.ItemName3.Text = "";
                this.ItemName4.Text = "";
                this.ItemName5.Text = "";
                this.ItemName6.Text = "";
                this.ItemName7.Text = "";
                this.ItemName8.Text = "";
                this.ItemName9.Text = "";
            } 
            else if (c.CollectionList.Count == 8)
            {
                this.ItemName1.Text = c.CollectionList[0].ItemPicFileName;
                this.ItemName2.Text = c.CollectionList[1].ItemPicFileName;
                this.ItemName3.Text = c.CollectionList[2].ItemPicFileName;
                this.ItemName4.Text = c.CollectionList[3].ItemPicFileName;
                this.ItemName5.Text = c.CollectionList[4].ItemPicFileName;
                this.ItemName6.Text = c.CollectionList[5].ItemPicFileName;
                this.ItemName7.Text = c.CollectionList[6].ItemPicFileName;
                this.ItemName8.Text = c.CollectionList[7].ItemPicFileName;
                this.ItemName9.Text = "";
            }
            else if (c.CollectionList.Count == 9)
            {
                this.ItemName1.Text = c.CollectionList[0].ItemPicFileName;
                this.ItemName2.Text = c.CollectionList[1].ItemPicFileName;
                this.ItemName3.Text = c.CollectionList[2].ItemPicFileName;
                this.ItemName4.Text = c.CollectionList[3].ItemPicFileName;
                this.ItemName5.Text = c.CollectionList[4].ItemPicFileName;
                this.ItemName6.Text = c.CollectionList[5].ItemPicFileName;
                this.ItemName7.Text = c.CollectionList[6].ItemPicFileName;
                this.ItemName8.Text = c.CollectionList[7].ItemPicFileName;
                this.ItemName9.Text = c.CollectionList[8].ItemPicFileName;
            }
        }
    }
}
