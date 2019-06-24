using FFImageLoading.Forms;
using Xamarin.Forms;

namespace PanCardViewSample.CardsFactory
{
	public class DefaultCardItemView : AbsoluteLayout
	{
		public DefaultCardItemView()
		{
			var tapGesture = new TapGestureRecognizer();
			tapGesture.Tapped += (s, e) => Application.Current.MainPage.DisplayAlert("Tap!", null, "Ok");
			GestureRecognizers.Add(tapGesture);

			var frame = new Frame
			{
				Padding = 5,
				HasShadow = false,
				CornerRadius = 10,
				IsClippedToBounds = true
			};
			frame.SetBinding(BackgroundColorProperty, "Color");
			Children.Add(frame, new Rectangle(.5, 0.4, 455, 270), AbsoluteLayoutFlags.PositionProportional);

			var image = new CachedImage
			{
				Aspect = Aspect.AspectFill
			};

			image.SetBinding(CachedImage.SourceProperty, "Source");

			frame.Content = image;
		}
	}
}