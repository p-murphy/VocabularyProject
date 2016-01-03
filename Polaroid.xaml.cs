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

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace November16th
{
    public sealed partial class Polaroid : UserControl
    {
        Page p;
        Collection c;

        public Polaroid(BitmapSource src, Page page, Collection col)
        {
            p = page;
            c = col;
            this.InitializeComponent();
            this.CollectionTileImage.Source = src;
            this.CollectionTileImage.Stretch = Stretch.Fill;


            if(c.CollectionList.Count == 8)
            {
                double gradientSpacing = 0.143;

                foreach(Item I in c.CollectionList)
                {
                    GradientStop gradStop = new GradientStop();

                    if(I.lvl == Levels.Introductory)
                        gradStop.Color = Colors.Black;
                    if (I.lvl == Levels.Beginner)
                        gradStop.Color = Colors.Green;
                    if (I.lvl == Levels.Intermediate)
                        gradStop.Color = Colors.Yellow;
                    if (I.lvl == Levels.Advanced)
                        gradStop.Color = Colors.Red;
                    if (I.lvl == Levels.Fluent)
                        gradStop.Color = Colors.Purple;
                    if (I.lvl == Levels.Native)
                        gradStop.Color = Colors.Blue;

                    gradStop.Offset = (c.CollectionList.IndexOf(I)) * gradientSpacing;
                    RectangleGradient.GradientStops.Add(gradStop);
                }
            }
            if(c.CollectionList.Count == 9)
            {
                double gradientSpacing = 0.125;

                foreach(Item I in c.CollectionList)
                {
                    GradientStop gradStop = new GradientStop();

                    if (I.lvl == Levels.Introductory)
                        gradStop.Color = Colors.Black;
                    if (I.lvl == Levels.Beginner)
                        gradStop.Color = Colors.Green;
                    if (I.lvl == Levels.Intermediate)
                        gradStop.Color = Colors.Yellow;
                    if (I.lvl == Levels.Advanced)
                        gradStop.Color = Colors.Red;
                    if (I.lvl == Levels.Fluent)
                        gradStop.Color = Colors.Purple;
                    if (I.lvl == Levels.Native)
                        gradStop.Color = Colors.Blue;

                    gradStop.Offset = (c.CollectionList.IndexOf(I)) * gradientSpacing;
                    RectangleGradient.GradientStops.Add(gradStop);
                }
            }
            //GradientStop blueGS = new GradientStop();
            //blueGS.Color = Colors.Blue;
            //blueGS.Offset = 0.0;
            //RectangleGradient.GradientStops.Add(blueGS);

            //GradientStop orangeGS = new GradientStop();
            //orangeGS.Color = Colors.Orange;
            //orangeGS.Offset = 0.25;
            //RectangleGradient.GradientStops.Add(orangeGS);

            //GradientStop yellowGS = new GradientStop();
            //yellowGS.Color = Colors.Yellow;
            //yellowGS.Offset = 0.50;
            //RectangleGradient.GradientStops.Add(yellowGS);

            //GradientStop greenGS = new GradientStop();
            //greenGS.Color = Colors.Green;
            //greenGS.Offset = 0.75;
            //RectangleGradient.GradientStops.Add(greenGS);

            //GradientStop redGS = new GradientStop();
            //redGS.Color = Colors.Red;
            //redGS.Offset = 1.0;
            //RectangleGradient.GradientStops.Add(redGS);

            //// Set Fill property of rectangle
            //blueRectangle.Fill = RectangleGradient;
        }

        private void MainButton_Click(object sender, RoutedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;
            if (c.CollectionList.Count == 8)
            {
                if (c.lvl == Levels.Introductory)
                {
                    rootFrame.Navigate(typeof(_8IntroPreviewPage), c.CollectionID);
                }
                else
                {
                    rootFrame.Navigate(typeof(_8StandardPreviewPage), c.CollectionID);
                }
            }

            if (c.CollectionList.Count == 9)
            {
                if (c.lvl == Levels.Introductory)
                {
                    rootFrame.Navigate(typeof(_9IntroPreviewPage), c.CollectionID);
                }
                else
                {
                    rootFrame.Navigate(typeof(_9StandardPreviewPage), c.CollectionID);
                }
            }
        }

        private void MainButton_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            p.DataContext = this.CollectionTileImage;
        }

        private void MainButton_GotFocus(object sender, RoutedEventArgs e)
        {
            p.DataContext = this.CollectionTileImage;
        }

        private void UserControl_LostFocus_1(object sender, RoutedEventArgs e)
        {
            p.DataContext = null;
        }

        private void UserControl_PointerExited_1(object sender, PointerRoutedEventArgs e)
        {
            p.DataContext = null;
        }
    }
}
