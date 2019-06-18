using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PanCardViewSample.ViewModels
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SurveySelection : ContentPage
	{
		public SurveySelection ()
		{
			InitializeComponent ();
		}

        private async void Class_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Survey.HowHappyIsYourClass());
        }

        private async void You_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Survey.HowHappyAreYou());
        }
    }
}