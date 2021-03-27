using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static Spotify_API.SpotifySearch;
using Spotify_API;

namespace Spotify_API
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Result = SearchSong(textBox1.Text);
            var ListArtist = new List<SpotifyArtist>();

            foreach (var Items in Result.tracks.items)
            {
                ListArtist.Add(new SpotifyArtist()
                {
                    ID = Items.id,
                    Image = Items.album[0].images[0].url,
                    Name = Items.name,
                    Popularity = Items.popularity.ToString()
                });
            }

        }
    }
}