using PanCardViewSample.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PanCardViewSample.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HappinessTools : ContentPage
    {
        ObservableCollection<TipsToHappinessModel> tipsToHappinessModels = new ObservableCollection<TipsToHappinessModel>() { };

        public HappinessTools ()
		{
			InitializeComponent ();
            ListPopulate();
            Ppt_View.ItemsSource = tipsToHappinessModels;
        }
        void ListPopulate()
        {
            
            tipsToHappinessModels.Add(new TipsToHappinessModel { oid = 0, image_path = "tools1.png", LinksStruct = new List<LinksStruct>() { new LinksStruct { DisplayText = "", Link = "" } } });
            tipsToHappinessModels.Add(new TipsToHappinessModel { oid = 1, image_path = "tools2.png", LinksStruct = new List<LinksStruct>() { new LinksStruct { DisplayText = "", Link = "" } } });
            tipsToHappinessModels.Add(new TipsToHappinessModel { oid = 2, image_path = "tools3.png", LinksStruct = new List<LinksStruct>() { new LinksStruct { DisplayText = "", Link = "" } } });
            tipsToHappinessModels.Add(new TipsToHappinessModel { oid = 3, image_path = "tools4.png", LinksStruct = new List<LinksStruct>() { new LinksStruct { DisplayText = "Skype in Classroom", Link = "https://education.microsoft.com/skype-in-the-classroom/overview" } } });
            tipsToHappinessModels.Add(new TipsToHappinessModel { oid = 4, image_path = "tools5.png", LinksStruct = new List<LinksStruct>() { new LinksStruct { DisplayText = "Flip Grid", Link = " https://flipgrid.com/" } } });
            tipsToHappinessModels.Add(new TipsToHappinessModel { oid = 5, image_path = "tools6.png", LinksStruct = new List<LinksStruct>() { new LinksStruct { DisplayText = "Empatico", Link = "https://empatico.org/" } } });
            tipsToHappinessModels.Add(new TipsToHappinessModel { oid = 6, image_path = "tools7.png", LinksStruct = new List<LinksStruct>() { new LinksStruct { DisplayText = "Sway", Link = "https://sway.office.com/" } } });
            //tipsToHappinessModels.Add(new TipsToHappinessModel { oid = 7, image_path = "tools8.png", LinksStruct = new List<LinksStruct>() { new LinksStruct { DisplayText = "", Link = "" } } });
            tipsToHappinessModels.Add(new TipsToHappinessModel { oid = 7, image_path = "tools8.png", LinksStruct = new List<LinksStruct>() { new LinksStruct { DisplayText = "Building a Better Future", Link = "http://www.bbtnb.com/sdgs.html" }, new LinksStruct { DisplayText = "Minecraft", Link = "https://education.minecraft.net/" } } });
            tipsToHappinessModels.Add(new TipsToHappinessModel { oid = 8, image_path = "tools9.png", LinksStruct = new List<LinksStruct>() { new LinksStruct { DisplayText = "Microsoft Paint?", Link = "https://www.digitalunite.com/technology-guides/creating-documents/microsoft-programs/what-microsoft-paint" } } });
            tipsToHappinessModels.Add(new TipsToHappinessModel { oid = 9, image_path = "tools10.png", LinksStruct = new List<LinksStruct>() { new LinksStruct { DisplayText = "Augmented Reality", Link = "https://thinkmobiles.com/blog/augmented-reality-education/" }, new LinksStruct { DisplayText = "AR and VR to the Classroom", Link = "https://www.iste.org/explore/In-the-classroom/25-resources-for-bringing-AR-and-VR-to-the-classroom" } } });
            tipsToHappinessModels.Add(new TipsToHappinessModel { oid = 10, image_path = "tools11.png", LinksStruct = new List<LinksStruct>() { new LinksStruct { DisplayText = "Day of Happiness", Link = "https://www.dayofhappiness.net/pack" }, new LinksStruct { DisplayText = "Happy Teacher", Link = "https://www.teachthought.com/pedagogy/really-truly-happy-teacher/" }, new LinksStruct { DisplayText = "Foster Generosity in Students", Link = "https://www.weareteachers.com/10-ways-foster-generosity-students/" }, new LinksStruct { DisplayText = "Tools for Instant Happiness", Link = "https://www.psychologytoday.com/intl/blog/bouncing-back/201209/15-tools-instant-happy" } } });
            tipsToHappinessModels.Add(new TipsToHappinessModel { oid = 11, image_path = "tools12.png", LinksStruct = new List<LinksStruct>() { new LinksStruct { DisplayText = "", Link = "" } } });
        }

        private async void Ppt_clicked(object sender, EventArgs e)
        {
            var item = (Xamarin.Forms.ImageButton)sender;
            int oid = Convert.ToInt32(item.CommandParameter.ToString());
            int countOfItems = tipsToHappinessModels[oid].LinksStruct.Count();
            List<string> buttonsList = new List<string>() { };
            for (int i = 0; i < countOfItems; i++)
            {
                if (string.IsNullOrEmpty(tipsToHappinessModels[oid].LinksStruct[i].DisplayText))
                    return;
                buttonsList.Add(tipsToHappinessModels[oid].LinksStruct[i].DisplayText);
            }
            var reply = await DisplayActionSheet("Open Links?", "cancel", null, buttonsList.ToArray());
            if (reply == "cancel")
                return;
            var selectedUrl = tipsToHappinessModels[oid].LinksStruct.First(s => s.DisplayText == reply).Link;
            Device.OpenUri(new Uri(selectedUrl.ToString()));
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Send(this, "AllowLandscape");
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Send(this, "PreventLandscape"); //during page close setting back to portrait 
        }
    }
}
	