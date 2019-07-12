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
    public partial class TipsToHappyClassroom : ContentPage
    {
        ObservableCollection<TipsToHappinessModel> tipsToHappinessModels = new ObservableCollection<TipsToHappinessModel>() { };
        public TipsToHappyClassroom()
        {
            InitializeComponent();
            ListPopulate();
            Ppt_View.ItemsSource = tipsToHappinessModels;
        }

        void ListPopulate()
        {
            tipsToHappinessModels.Add(new TipsToHappinessModel { oid = 0, image_path = "happyClass1.png", LinksStruct = new List<LinksStruct>() { new LinksStruct { DisplayText = "", Link = "" } } });
            tipsToHappinessModels.Add(new TipsToHappinessModel { oid = 1, image_path = "happyClass2.png", LinksStruct = new List<LinksStruct>() { new LinksStruct { DisplayText = "Research Evidence", Link = "https://www.gov.uk/government/publications/the-link-between-pupil-health-and-wellbeing-and-attainment" } } });
            tipsToHappinessModels.Add(new TipsToHappinessModel { oid = 2, image_path = "happyClass3.png", LinksStruct = new List<LinksStruct>() { new LinksStruct { DisplayText = "", Link = "" } } });
            tipsToHappinessModels.Add(new TipsToHappinessModel { oid = 3, image_path = "happyClass4.png", LinksStruct = new List<LinksStruct>() { new LinksStruct { DisplayText = "", Link = "" } } });
            tipsToHappinessModels.Add(new TipsToHappinessModel { oid = 4, image_path = "happyClass5.png", LinksStruct = new List<LinksStruct>() { new LinksStruct { DisplayText = "", Link = "" } } });
            tipsToHappinessModels.Add(new TipsToHappinessModel { oid = 5, image_path = "happyClass6.png", LinksStruct = new List<LinksStruct>() { new LinksStruct { DisplayText = "", Link = "" } } });
            tipsToHappinessModels.Add(new TipsToHappinessModel { oid = 6, image_path = "happyClass7.png", LinksStruct = new List<LinksStruct>() { new LinksStruct { DisplayText = "Mindful Activities", Link = "https://www.thepathway2success.com/10-mindfulness-activities-you-can-try-today/" } } });
            tipsToHappinessModels.Add(new TipsToHappinessModel { oid = 7, image_path = "happyClass8.png", LinksStruct = new List<LinksStruct>() { new LinksStruct { DisplayText = "", Link = "" } } });
            tipsToHappinessModels.Add(new TipsToHappinessModel { oid = 8, image_path = "happyClass9.png", LinksStruct = new List<LinksStruct>() { new LinksStruct { DisplayText = "", Link = "" } } });
            tipsToHappinessModels.Add(new TipsToHappinessModel { oid = 9, image_path = "happyClass10.png", LinksStruct = new List<LinksStruct>() { new LinksStruct { DisplayText = "", Link = "" } } });
            tipsToHappinessModels.Add(new TipsToHappinessModel { oid = 10, image_path = "happyClass11.png", LinksStruct = new List<LinksStruct>() { new LinksStruct { DisplayText = "", Link = "" } } });
            tipsToHappinessModels.Add(new TipsToHappinessModel { oid = 11, image_path = "happyClass12.png", LinksStruct = new List<LinksStruct>() { new LinksStruct { DisplayText = "", Link = "" } } });
            tipsToHappinessModels.Add(new TipsToHappinessModel { oid = 12, image_path = "happyClass13.png", LinksStruct = new List<LinksStruct>() { new LinksStruct { DisplayText = "Random Act Of Kindness", Link = "https://www.randomactsofkindness.org/for-educators" } } });
            tipsToHappinessModels.Add(new TipsToHappinessModel { oid = 13, image_path = "happyClass14.png", LinksStruct = new List<LinksStruct>() { new LinksStruct { DisplayText = "", Link = "" } } });
            tipsToHappinessModels.Add(new TipsToHappinessModel { oid = 14, image_path = "happyClass15.png", LinksStruct = new List<LinksStruct>() { new LinksStruct { DisplayText = "", Link = "" } } });
            tipsToHappinessModels.Add(new TipsToHappinessModel { oid = 15, image_path = "happyClass16.png", LinksStruct = new List<LinksStruct>() { new LinksStruct { DisplayText = "", Link = "" } } });
            tipsToHappinessModels.Add(new TipsToHappinessModel { oid = 16, image_path = "happyClass17.png", LinksStruct = new List<LinksStruct>() { new LinksStruct { DisplayText = "", Link = "" } } });
            tipsToHappinessModels.Add(new TipsToHappinessModel { oid = 17, image_path = "happyClass18.png", LinksStruct = new List<LinksStruct>() { new LinksStruct { DisplayText = "", Link = "" } } });
            tipsToHappinessModels.Add(new TipsToHappinessModel { oid = 18, image_path = "happyClass19.png", LinksStruct = new List<LinksStruct>() { new LinksStruct { DisplayText = "", Link = "" } } });
            tipsToHappinessModels.Add(new TipsToHappinessModel { oid = 19, image_path = "happyClass20.png", LinksStruct = new List<LinksStruct>() { new LinksStruct { DisplayText = "", Link = "" } } });
            tipsToHappinessModels.Add(new TipsToHappinessModel { oid = 20, image_path = "happyClass21.png", LinksStruct = new List<LinksStruct>() { new LinksStruct { DisplayText = "", Link = "" } } });
            tipsToHappinessModels.Add(new TipsToHappinessModel { oid = 21, image_path = "happyClass22.png", LinksStruct = new List<LinksStruct>() { new LinksStruct { DisplayText = "", Link = "" } } });
            tipsToHappinessModels.Add(new TipsToHappinessModel { oid = 22, image_path = "happyClass23.png", LinksStruct = new List<LinksStruct>() { new LinksStruct { DisplayText = "", Link = "" } } });
            tipsToHappinessModels.Add(new TipsToHappinessModel { oid = 23, image_path = "happyClass24.png", LinksStruct = new List<LinksStruct>() { new LinksStruct { DisplayText = "", Link = "" } } });
            tipsToHappinessModels.Add(new TipsToHappinessModel { oid = 24, image_path = "happyClass25.png", LinksStruct = new List<LinksStruct>() { new LinksStruct { DisplayText = "", Link = "" } } });
            tipsToHappinessModels.Add(new TipsToHappinessModel { oid = 25, image_path = "happyClass26.png", LinksStruct = new List<LinksStruct>() { new LinksStruct { DisplayText = "", Link = "" } } });
            tipsToHappinessModels.Add(new TipsToHappinessModel { oid = 26, image_path = "happyClass27.png", LinksStruct = new List<LinksStruct>() { new LinksStruct { DisplayText = "", Link = "" } } });
            tipsToHappinessModels.Add(new TipsToHappinessModel { oid = 27, image_path = "happyClass28.png", LinksStruct = new List<LinksStruct>() { new LinksStruct { DisplayText = "", Link = "" } } });
            tipsToHappinessModels.Add(new TipsToHappinessModel { oid = 28, image_path = "happyClass29.png", LinksStruct = new List<LinksStruct>() { new LinksStruct { DisplayText = "", Link = "" } } });
            tipsToHappinessModels.Add(new TipsToHappinessModel { oid = 29, image_path = "happyClass30.png", LinksStruct = new List<LinksStruct>() { new LinksStruct { DisplayText = "Edutopia.org", Link = "https://www.edutopia.org/blog/simple-ways-cultivate-happiness-schools-elena-aguilar" }, new LinksStruct { DisplayText = "Teachertoolkit.co.uk", Link = "https://www.teachertoolkit.co.uk/2018/09/10/happy-classroom/" }, new LinksStruct { DisplayText = "Weareteachers.com", Link = "https://www.weareteachers.com/21-simple-ways-to-integrate-social-emotional-learning-throughout-the-day/" }, new LinksStruct { DisplayText = "Greatergood.berkley.edu", Link = "https://greatergood.berkeley.edu/" } } });
            tipsToHappinessModels.Add(new TipsToHappinessModel { oid = 30, image_path = "happyClass31.png", LinksStruct = new List<LinksStruct>() { new LinksStruct { DisplayText = "Edutopia.org", Link = "https://www.edutopia.org/blog/simple-ways-cultivate-happiness-schools-elena-aguilar" }, new LinksStruct { DisplayText = "Teachertoolkit.co.uk", Link = "https://www.teachertoolkit.co.uk/2018/09/10/happy-classroom/" }, new LinksStruct { DisplayText = "Weareteachers.com", Link = "https://www.weareteachers.com/21-simple-ways-to-integrate-social-emotional-learning-throughout-the-day/" }, new LinksStruct { DisplayText = "Greatergood.berkley.edu", Link = "https://greatergood.berkeley.edu/" } } });


           
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