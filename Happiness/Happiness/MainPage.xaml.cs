using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Happiness.models;


namespace Happiness
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<DashBoardBanner> DBbanner = new ObservableCollection<DashBoardBanner>() { };

        public MainPage()
        {
            InitializeComponent();

            DBbanner.Add(new DashBoardBanner { ItemIndex = "1", Name = "Hello 01", Image = "g1.jpg" });
            DBbanner.Add(new DashBoardBanner { ItemIndex = "2", Name = "Hello 02", Image = "id.png" });
            DBbanner.Add(new DashBoardBanner { ItemIndex = "3", Name = "Hello 03", Image = "idea.jpg" });
            topBannerCoverFlowView.ItemsSource = DBbanner;
            TopBannerCount.Text = SelectedItemIndex((DashBoardBanner)topBannerCoverFlowView.SelectedItem) + "/" + DBbanner.Count;

            topBannerCoverFlowView.ItemSwiped += async (PanCardView.CardsView view, PanCardView.EventArgs.ItemSwipedEventArgs args) => { TopBannerCount.Text = SelectedItemIndex((DashBoardBanner)args.Item) + "/" + DBbanner.Count; };

        }

        private string SelectedItemIndex(DashBoardBanner DBbanner)
        {
            /* BUG BUG BUG BUG BUG BUG BUG BUG BUG BUG BUG BUG BUG BUG BUG BUG BUG
            * This is taking the element that WAS selected for swiping. <= BUG ALERT!
            * This index doesn't represent the item that is currently selected. <= BUG ALERT!
            * BUG BUG BUG BUG BUG BUG BUG BUG BUG BUG BUG BUG BUG BUG BUG BUG BUG           
            */
            return DBbanner.Name.ToString();
        }

        private void About_Clicked(object sender, EventArgs e)
        {

        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {

        }
    }
}
