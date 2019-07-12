using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PanCardViewSample.ViewModels;
using PanCardViewSample.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Reflection;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;


namespace PanCardViewSample
{
	
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
	{
        ObservableCollection<TopBanners> topBanners = new ObservableCollection<TopBanners>() { };
        ObservableCollection<MiddleBanners> middleBanners = new ObservableCollection<MiddleBanners>() { };
       

        public MainPage()
        {
            InitializeComponent();
            

            topBanners.Add(new TopBanners { ItemIndex = "0", Name = "Tools 01", Image = "classroom.jpg" });
            topBanners.Add(new TopBanners { ItemIndex = "1", Name = "Tips 02", Image = "Happiness.jpg" });
            topBanners.Add(new TopBanners { ItemIndex = "2", Name = "Index 03", Image = "Tools.png" });
            topBanners.Add(new TopBanners { ItemIndex = "3", Name = "Tips 04", Image = "Tips.png" });
            //topBanners.Add(new TopBanners { ItemIndex = "4", Name = "Test 05", Image = "classroom.jpg" });
            topBannerCoverFlowView.ItemsSource = topBanners;
            //TopBannerCount.Text = SelectedItemIndex((TopBanners)topBannerCoverFlowView.SelectedItem) + "/" + topBanners.Count;

            //topBannerCoverFlowView.ItemSwiped += async (PanCardView.CardsView view, PanCardView.EventArgs.ItemSwipedEventArgs args) => { TopBannerCount.Text = SelectedItemIndex((TopBanners)args.Item) + "/" + topBanners.Count; };

            //middleBanners.Add(new MiddleBanners { ItemIndex = "1", Name = "Event JPG", Image = "event.jpg" });
            //middleBanners.Add(new MiddleBanners { ItemIndex = "2", Name = "Event 2 JPG", Image = "event.jpg" });
            //middleBannerCoverCarouselView.ItemsSource = middleBanners;

            //webView.Source = "https://player.vimeo.com/video/332724932";
            //var assembly = typeof(EmbeddedImages).GetTypeInfo().Assembly;
            //foreach (var res in assembly.GetManifestResourceNames())
            //{
            //    System.Diagnostics.Debug.WriteLine("found resource: " + res);
            //}
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

        private async void selectedImage(object sender, EventArgs e)
        {
            //if (topBannerCoverFlowView.SelectedIndex == 0)
            //{
            //    await Navigation.PushAsync(new CardsSampleView());
            //}
            if (topBannerCoverFlowView.SelectedIndex == 0)
            {
                //await Navigation.PushAsync(new CarouselSampleViewNoTemplate());
                await Navigation.PushAsync(new TipsToHappyClassroom());
            }
            else if (topBannerCoverFlowView.SelectedIndex == 1)
            {
                await Navigation.PushAsync(new SurveySelection());
            }
            else if (topBannerCoverFlowView.SelectedIndex == 2)
            {
                //await Navigation.PushAsync(new CarouselSampleXamlView());
                await Navigation.PushAsync(new HappinessTools());

            }
            else
            {
                await Navigation.PushAsync(new CubeSampleXamlView());
            }
            //else
            //{
            //    await Navigation.PushAsync(new CarouselSampleViewNoTemplate());
            //}
        }

        private async void About_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ViewModels.About());
        }

    }
}
