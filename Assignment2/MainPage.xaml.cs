using Assignment2.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Assignment2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private ObservableCollection<Song> songs;
        public ObservableCollection<Song> Songs { get => Model.SongModel.GetSongs(); set => Model.SongModel.SetSongs(value); }

        private bool isPlaying = false;

        int onPlay = 0;

        public MainPage()
        {
            this.InitializeComponent();
            mp3Frame.Navigate(typeof(View.mp3Form));
            mp4Frame.Navigate(typeof(View.mp4Form));
        }
        
       
        private void loadSong(Song currentSong)
        {
            this.nowPlaying.Text = currentSong.Title + " - " + currentSong.Singer;
            //MediaPlayer.Source = new Uri(currentSong.Link);
        }

        private void playSong()
        {
            MediaPlayer.Play();
            PlayButton.Icon = new SymbolIcon(Symbol.Pause);
            isPlaying = true;
        }

        private void pauseSong()
        {
            MediaPlayer.Pause();
            PlayButton.Icon = new SymbolIcon(Symbol.Play);
            isPlaying = false;

        }

        private void resumeSong()
        {
            if (!isPlaying)
            {
                playSong();
            }
        }

        private void playBack(object sender, RoutedEventArgs e)
        {
            MediaPlayer.Stop();
            if (onPlay > 0)
            {
                onPlay = onPlay - 1;

            }
            else
            {
                onPlay = Songs.Count - 1;
            }
            loadSong(Songs[onPlay]);
            playSong();
           // MenuList.SelectedIndex = onPlay;
        }

        private void playNext(object sender, RoutedEventArgs e)
        {
            MediaPlayer.Stop();
            if (onPlay < Songs.Count - 1)
            {
                onPlay = onPlay + 1;
            }
            else
            {
                onPlay = 0;
            }
            loadSong(Songs[onPlay]);
            playSong();
            //MenuList.SelectedIndex = onPlay;
        }

        private void Play_Click(object sender, RoutedEventArgs e)
        {
            if (isPlaying)
            {
                pauseSong();

            }
            else
            {
                playSong();
            }
        }

        private void volumeSlider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            Slider vol = sender as Slider;

            if (vol != null)
            {
                MediaPlayer.Volume = vol.Value / 100;

                this.volume.Text = vol.Value.ToString();
            }
        }
    }
}
