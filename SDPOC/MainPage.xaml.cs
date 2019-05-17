using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDPOC.models;
using Xamarin.Forms;

namespace SDPOC
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        ObservableCollection<TopBanners> topBanners = new ObservableCollection<TopBanners>() { };
        ObservableCollection<MiddleBanners> middleBanners = new ObservableCollection<MiddleBanners>() { };

        public MainPage()
        {
            InitializeComponent();

            topBanners.Add(new TopBanners { ItemIndex = "1", Name = "Hello 01", Image = "Games.png" });
            topBanners.Add(new TopBanners { ItemIndex = "2", Name = "Hello 02", Image = "News.png" });
            topBanners.Add(new TopBanners { ItemIndex = "3", Name = "Hello 03", Image = "Rewards.png" });
            topBanners.Add(new TopBanners { ItemIndex = "4", Name = "Hello 04", Image = "Events.png" });
            topBannerCoverFlowView.ItemsSource = topBanners;
            TopBannerCount.Text = SelectedItemIndex((TopBanners) topBannerCoverFlowView.SelectedItem) + "/" + topBanners.Count;

            topBannerCoverFlowView.ItemSwiped += async (PanCardView.CardsView view, PanCardView.EventArgs.ItemSwipedEventArgs args) => { TopBannerCount.Text = SelectedItemIndex((TopBanners)args.Item) + "/" + topBanners.Count; };

            //middleBanners.Add(new MiddleBanners { ItemIndex = "1", Name = "Event JPG", Image = "event.jpg" });
            //middleBanners.Add(new MiddleBanners { ItemIndex = "2", Name = "Event 2 JPG", Image = "event.jpg" });
            //middleBannerCoverCarouselView.ItemsSource = middleBanners;

            //webView.Source = "https://player.vimeo.com/video/332724932";
        }

        private string SelectedItemIndex(TopBanners topBanners)
        {
            /* BUG BUG BUG BUG BUG BUG BUG BUG BUG BUG BUG BUG BUG BUG BUG BUG BUG
            * This is taking the element that WAS selected for swiping. <= BUG ALERT!
            * This index doesn't represent the item that is currently selected. <= BUG ALERT!
            * BUG BUG BUG BUG BUG BUG BUG BUG BUG BUG BUG BUG BUG BUG BUG BUG BUG           
            */
            return topBanners.Name.ToString();
        }

      

        private void About_Clicked(object sender, EventArgs e)
        {
            
        }
    }
}
