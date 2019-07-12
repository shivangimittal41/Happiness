using PanCardView;
using PanCardView.Controls;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using CardCarouselView = PanCardView.CarouselView;
namespace PanCardViewSample.Views
{
    public class CarouselSampleViewNoTemplate : ContentPage
    {
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
        public CarouselSampleViewNoTemplate()
        {
            Title = "CarouselSampleViewNoTemplate";

            var carousel = new CardCarouselView
            {
                HeightRequest = 200,
                WidthRequest = 400,
                //ItemsSource = new[] {
                ItemsSource = new ObservableCollection<object> { 
                    new { Source = "happyClass1.png", Color = Color.Red },
                new { Source = "happyClass2.png", Color = Color.Green },
                new { Source = "happyClass3.png" , Color = Color.Gold },
                new { Source = "happyClass4.png" , Color = Color.Silver },
                new { Source = "happyClass5.png", Color = Color.Blue },
                new { Source = "happyClass6.png", Color = Color.Red },
                new { Source = "happyClass7.png", Color = Color.Green },
                new { Source = "happyClass8.png" , Color = Color.Gold },
                new { Source = "happyClass9.png" , Color = Color.Silver },
                new { Source = "happyClass10.png", Color = Color.White },
                new { Source = "happyClass11.png", Color = Color.AliceBlue },
                new { Source = "happyClass12.png", Color = Color.WhiteSmoke },
                new { Source = "happyClass13.png", Color = Color.Black },
                new { Source = "happyClass14.png", Color = Color.Black },
                new { Source = "happyClass15.png", Color = Color.Black },
                new { Source = "happyClass16.png", Color = Color.Black },
                new { Source = "happyClass17.png", Color = Color.Black },
                new { Source = "happyClass18.png", Color = Color.Black },
                new { Source = "happyClass19.png", Color = Color.Black },
                new { Source = "happyClass20.png", Color = Color.Black },
                new { Source = "happyClass21.png", Color = Color.Black },
                new { Source = "happyClass22.png", Color = Color.Black },
                new { Source = "happyClass23.png", Color = Color.White },
                new { Source = "happyClass24.png", Color = Color.LightYellow },
                new { Source = "happyClass25.png", Color = Color.OliveDrab },
                new { Source = "happyClass26.png", Color = Color.Black },
                new { Source = "happyClass27.png", Color = Color.Black },
                new { Source = "happyClass28.png", Color = Color.Black },
                new { Source = "happyClass29.png", Color = Color.Black },
                new { Source = "happyClass30.png", Color = Color.Black },
                new { Source = "happyClass31.png", Color = Color.Black }
                    //new BoxView { Color = Color.Red },
                    //new BoxView { Color = Color.Blue},
                    //new BoxView { Color = Color.Yellow}

                //    new BoxView { source = "happyClass1.png", Color = Color.Red },
                //new BoxView { Source = "happyClass2.png", Color = Color.Green },
                //new BoxView { Source = "happyClass3.png" , Color = Color.Gold },
                //new BoxView { Source = "happyClass4.png" , Color = Color.Silver },
                //new BoxView { Source = "happyClass5.png", Color = Color.Blue },
                //new BoxView { Source = "happyClass6.png", Color = Color.Red },
                //new BoxView { Source = "happyClass7.png", Color = Color.Green },
                //new BoxView { Source = "happyClass8.png" , Color = Color.Gold },
                //new BoxView { Source = "happyClass9.png" , Color = Color.Silver },
                //new BoxView { Source = "happyClass10.png", Color = Color.White },
                //new BoxView { Source = "happyClass11.png", Color = Color.AliceBlue },
                //new BoxView { Source = "happyClass12.png", Color = Color.WhiteSmoke },
                //new BoxView { Source = "happyClass13.png", Color = Color.Black },
                //new BoxView { Source = "happyClass14.png", Color = Color.Black },
                //new BoxView { Source = "happyClass15.png", Color = Color.Black },
                //new BoxView { Source = "happyClass16.png", Color = Color.Black },
                //new BoxView { Source = "happyClass17.png", Color = Color.Black },
                //new BoxView { Source = "happyClass18.png", Color = Color.Black },
                //new BoxView { Source = "happyClass19.png", Color = Color.Black },
                //new BoxView { Source = "happyClass20.png", Color = Color.Black },
                //new BoxView { Source = "happyClass21.png", Color = Color.Black },
                //new BoxView { Source = "happyClass22.png", Color = Color.Black },
                //new BoxView { Source = "happyClass23.png", Color = Color.White },
                //new BoxView { Source = "happyClass24.png", Color = Color.LightYellow },
                //new BoxView { Source = "happyClass25.png", Color = Color.OliveDrab },
                //new BoxView { Source = "happyClass26.png", Color = Color.Black },
                //new BoxView { Source = "happyClass27.png", Color = Color.Black },
                //new BoxView { Source = "happyClass28.png", Color = Color.Black },
                //new BoxView { Source = "happyClass29.png", Color = Color.Black },
                //new BoxView { Source = "happyClass30.png", Color = Color.Black },
                //new BoxView { Source = "happyClass31.png", Color = Color.Black }


                },
                IsCyclical = false
            };

            var button = new Button { Text = "Select last" };
            button.Clicked += (sender, args) => { carousel.SelectedIndex = 2; };

            Content = new ParentScrollView
            {
                Content = new StackLayout
                {
                    Children = {
                        new StackLayout
                        {
                            Children = {
                                carousel
                            }
                        },
                        button
                    }
                }
            };
        }
    }
}