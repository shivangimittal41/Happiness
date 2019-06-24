using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;
using System.Linq;
using FFImageLoading;
using PanCardView.Extensions;

namespace PanCardViewSample.ViewModels
{
    public sealed class CarouselSampleXamlViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int _currentIndex;
        private int _ImageCount = 1058;



        public CarouselSampleXamlViewModel()
        { 
            Items = new ObservableCollection<object>
            {
                new { Source = "tools1.png", Color = Color.Red },
                new { Source = "tools2.png", Color = Color.Green },
                new { Source = "tools3.png", Color = Color.Gold },
                new { Source = "tools4.png", Color = Color.Silver },
                new { Source = "tools5.png", Color = Color.Blue },
                new { Source = "tools6.png", Color = Color.Red },
                new { Source = "tools7.png", Color = Color.Green },
                new { Source = "tools8.png", Color = Color.Gold },
                new { Source = "tools9.png", Color = Color.Silver },
                new { Source = "tools10.png", Color = Color.Blue },
                new { Source = "tools11.png", Color = Color.Blue },
                new { Source = "tools12.png", Color = Color.Blue },
                new { Source = "tools13.png", Color = Color.Blue }
                //new { Source = CreateSource(), Ind = _ImageCount++, Color = Color.Red },
                //new { Source = CreateSource(), Ind = _ImageCount++, Color = Color.Green },
                //new { Source = CreateSource(), Ind = _ImageCount++, Color = Color.Gold },
                //new { Source = CreateSource(), Ind = _ImageCount++, Color = Color.Silver },
                //new { Source = CreateSource(), Ind = _ImageCount++, Color = Color.Blue }
            };

            PanPositionChangedCommand = new Command(v =>
            {
                if (IsAutoAnimationRunning || IsUserInteractionRunning)
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