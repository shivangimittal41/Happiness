using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PanCardViewSample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselSampleXamlView : ContentPage
    {
		public CarouselSampleXamlView()
		{
			InitializeComponent();
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
