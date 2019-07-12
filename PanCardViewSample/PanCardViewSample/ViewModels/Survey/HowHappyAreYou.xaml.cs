using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PanCardViewSample.ViewModels.Survey
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HowHappyAreYou : ContentPage
	{
		public HowHappyAreYou ()
		{
			InitializeComponent ();
            webView.Source = "https://www.surveymonkey.com/r/Y5X3NX3";
        }

        //async void OnBackButtonClicked(object sender, EventArgs e)
        //{
        //    if (webView.CanGoBack)
        //    {
        //        webView.GoBack();
        //    }
        //    else
        //    {
        //        await Navigation.PopAsync();
        //    }
        //}

        //void OnForwardButtonClicked(object sender, EventArgs e)
        //{
        //    if (webView.CanGoForward)
        //    {
        //        webView.GoForward();
        //    }
        //}
    }
}