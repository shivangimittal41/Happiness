using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDPOC.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Quiz : ContentPage
    {
        public Quiz()
        {
            InitializeComponent();
        }

        private async void Class_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pages.HpwHappyClassroom());
        }

        private async void You_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pages.YourHappinessIndex());
        }

       
    }
}