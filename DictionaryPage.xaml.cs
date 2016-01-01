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
    public sealed partial class DictionaryPage : November16th.Common.LayoutAwarePage
    {
        string prefix = "ms-appx:///Images/PicabularyDemo/";
        string postfix = ".jpg";

        public DictionaryPage()
        {

            this.InitializeComponent();
            foreach (Item I in DictionaryDataList.instance.ItemList)
            {
                BitmapImage src = new BitmapImage(new Uri(prefix + I.ItemCol + "/" + I.ItemPicFileName + postfix, UriKind.Absolute));
                Image img = new Image();
                img.Source = src;
                img.Height = 100;
                img.Width = 100;
                img.Margin = new Thickness(5);
                StackPanel entry = new StackPanel();
                entry.Orientation = Orientation.Horizontal;
                TextBlock txt = new TextBlock();
                txt.Text = I.ItemPicFileName;
                txt.Margin = new Thickness(5);
                txt.FontSize = 32;
                entry.Children.Add(img);
                entry.Children.Add(txt);

                DictionaryStackPanel.Children.Add(entry);

            }

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
    }
}
