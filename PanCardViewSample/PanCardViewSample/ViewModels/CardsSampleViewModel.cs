using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;
using System.Linq;
using FFImageLoading;
using PanCardView.Extensions;

namespace PanCardViewSample.ViewModels
{
	public sealed class CardsSampleViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		private int _currentIndex;
		private int _ImageCount = 1058;

		public CardsSampleViewModel()
		{
			Items = new ObservableCollection<object>
			{
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

            };

			PanPositionChangedCommand = new Command(v =>
			{
                if(IsAutoAnimationRunning || IsUserInteractionRunning)
                {
                    return;
                }

                var index = CurrentIndex + (bool.Parse(v.ToString()) ? 1 : -1);
                if (index < 0 || index >= Items.Count)
                {
                    return;
                }
                CurrentIndex = index;
			});

			RemoveCurrentItemCommand = new Command(() =>
			{
				if (!Items.Any())
				{ 
					return;
				}
				Items.RemoveAt(CurrentIndex.ToCyclingIndex(Items.Count));
			});

            GoToLastCommand = new Command(() =>
            {
                CurrentIndex = Items.Count - 1;
            });
		}

		public ICommand PanPositionChangedCommand { get; }

		public ICommand RemoveCurrentItemCommand { get; }

        public ICommand GoToLastCommand { get; }

        public int CurrentIndex
		{
			get => _currentIndex;
			set
			{
				_currentIndex = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentIndex)));
			}
		}

        public bool IsAutoAnimationRunning { get; set; }

        public bool IsUserInteractionRunning { get; set; }

        public ObservableCollection<object> Items { get; }

		private string CreateSource()
		{
			var source = $"https://picsum.photos/500/500?image={_ImageCount}";
			return source;
           
		}
	}
}