using Plugin.SimpleAudioPlayer;
using Xamarin.Forms;

namespace BlankFormApp
{
    public partial class BlankFormAppPage : ContentPage
    {
        MediaPlayerViewModel viewModel;
        public BlankFormAppPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new MediaPlayerViewModel();
            Padding = PagePadding;

            viewModel.Init();
            viewModel.MediaPlayer.Play();
            label1.Text = viewModel.MediaPlayer.ToString();
            label2.Text = viewModel.MediaPlayer.MediaExtractor.ToString();
            //These flows errors on Android.
            //label3.Text = viewModel.MediaPlayer.Duration.ToString();
            //label4.Text = viewModel.MediaPlayer.Position.ToString();

            //SimpleAudioPlayer Reference https://blog.xamarin.com/adding-sound-xamarin-forms-app/
            //var player = CrossSimpleAudioPlayer.Current;
            //player.Load("wang04.mp3");
            //player.Play();
        }

        public static readonly Thickness PagePadding = GetPagePadding();

        private static Thickness GetPagePadding()
        {
            double topPadding;

            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    topPadding = 20;
                    break;
                default:
                    topPadding = 0;
                    break;
            }

            return new Thickness(5, topPadding, 5, 0);
        }
    }

}
