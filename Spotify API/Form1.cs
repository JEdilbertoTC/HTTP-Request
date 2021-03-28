using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static Spotify_API.Spotify;

namespace Spotify_API
{
    public partial class Form1 : Form
    {
        SpotifySearch spotifySearch = new SpotifySearch();

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Result = spotifySearch.SearchArtist(textBox1.Text);
            var ListArtist = new List<SpotifyArtist>();
             foreach (Artist Items in Result.artists.items)
              {
                  ListArtist.Add(new SpotifyArtist()
                  {
                      ID = Items.id,
                      Followers = Items.followers.total.ToString(),
                      Image = Items.images[0].url,
                      Name = Items.name,
                      Popularity = Items.popularity.ToString()
                  });
              }
            
        }
    }
}