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
	public partial class HowHappyIsYourClass : ContentPage
	{
		public HowHappyIsYourClass ()
		{
			InitializeComponent ();
            webView.Source = "http://www.surveymonkey.com/r/YWK385D";
        }
	}
}