using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;
using Microsoft.Win32;

namespace WpfTutorialSamples.Audio_and_Video
{
    public partial class MediaPlayerAudioControlSample : Window
    {
        private MediaPlayer mediaPlayer = new MediaPlayer();

        public MediaPlayerAudioControlSample()
        {
            InitializeComponent();

        }
        void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            lblStatus.Content = "Choosing file now...";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "MP3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                mediaPlayer.Open(new Uri(openFileDialog.FileName));
                SongName.Content = openFileDialog.FileName;
            }
                        
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            if (mediaPlayer.Source != null && mediaPlayer.NaturalDuration.HasTimeSpan)
            {
                lblStatus.Content = String.Format("{0} / {1}", mediaPlayer.Position.ToString(@"mm\:ss"), mediaPlayer.NaturalDuration.TimeSpan.ToString(@"mm\:ss"));
                sliderSeek.Minimum = 0;
                sliderSeek.Maximum = mediaPlayer.NaturalDuration.TimeSpan.TotalSeconds;
                sliderSeek.Value = mediaPlayer.Position.TotalSeconds;
                sliderSeek.SelectionEnd = mediaPlayer.NaturalDuration.TimeSpan.TotalSeconds;
            }
            else
                lblStatus.Content = "No file selected...";
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Play();
            volumnbar.Value = mediaPlayer.Volume;
        }

        private void btnPause_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Pause();
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Stop();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            mediaPlayer.Volume = volumnbar.Value;
        }

        private void sliderontime(object sender, RoutedEventArgs e)
        {
            int pos = Convert.ToInt32(sliderSeek.Value);
            mediaPlayer.Position = new TimeSpan(0, 0, 0, pos, 0);
        }

        private void slidertimechange(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (sliderSeek.IsMouseCaptureWithin)
            {
                int pos = Convert.ToInt32(sliderSeek.Value);
                mediaPlayer.Position = new TimeSpan(0, 0, 0, pos, 0);
            }
        }
    }
}