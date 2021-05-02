using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static Spotify_API.SpotifySearch;

namespace Spotify_API
{
    public partial class Spotify : Form
    {

        SpotifySearch spotifySearch = new SpotifySearch();
        ShowPlaylist showPlaylist = new ShowPlaylist();
        Dictionary<PictureBox, ListBox> Info;
        Dictionary<TextBox, ListBox> Info2;
        Dictionary<PictureBox, ListBox> InfoTrack;
        SearchAlbum album = new SearchAlbum();

        public Spotify()
        {
            InitializeComponent();
            label1.Visible = false;
            label2.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            button3.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            playid.Visible = false;
            uris.Visible = false;
            button5.Visible = false;
        }

        private void RemovePrevious(Dictionary<PictureBox, ListBox> lists)
        {
            if (lists != null)
            {
                foreach (var remove in lists)
                {
                    Controls.Remove(remove.Key);
                    Controls.Remove(remove.Value);
                }
            }
        }

        private List<SpotifyArtist> SaveListArtist(Root artists)
        {
            var ListArtist = new List<SpotifyArtist>();
            foreach (var Items in artists.artists.items)
            {
                ListArtist.Add(new SpotifyArtist()
                {
                    ID = Items.id,
                    Followers = Items.followers.total.ToString(),
                    Image = Items.images.Count > 0 ? Items.images[0].url : "https://user-images.githubusercontent.com/24848110/33519396-7e56363c-d79d-11e7-969b-09782f5ccbab.png",
                    Name = Items.name,
                    Popularity = Items.popularity.ToString(),
                    Genres = Items.genres.Count > 0 ? Items.genres[0] : "Unknown"
                });
            }
            return ListArtist;
        }

        private List<SpotifyTrack> SaveListTrack(Songs Tracks)
        {
            var ListTracks = new List<SpotifyTrack>();
            foreach (var Items in Tracks.tracks.items)
            {
                ListTracks.Add(new SpotifyTrack()
                {
                    nameSong = Items.name,
                    duration_ms = Items.duration_ms.ToString(),
                    @explicit = Items.@explicit.ToString(),
                    imageAlbum = Items.album.images.Count > 0 ? Items.album.images[0].url : "https://user-images.githubusercontent.com/24848110/33519396-7e56363c-d79d-11e7-969b-09782f5ccbab.png",
                    nameAlbum = Items.album.name,
                    nameArtist = Items.artists[0].name,
                    popularity = Items.popularity.ToString()
                });
            }
            return ListTracks;
        }

        private Dictionary<PictureBox, ListBox> ShowArtists(List<SpotifyArtist> ListArtists)
        {
            int inc = 0;
            // Dictionary<PictureBox, ListBox> Map;
            Info = new Dictionary<PictureBox, ListBox>();
            foreach (var items in ListArtists)
            {
                PictureBox picture = AddPictureArtist(ref inc, items);
                ListBox listBox = AddInfoArtist(ref inc, items, picture);
                Info.Add(picture, listBox);
            }
            return Info;
        }

        private PictureBox AddPictureTrack(ref int inc, SpotifyTrack items)
        {
            inc += 100;
            PictureBox picture = new PictureBox();
            picture.Visible = true;
            picture.SizeMode = PictureBoxSizeMode.Zoom;
            picture.Location = new Point(400, SArtist.Location.Y + inc - 50);
            picture.Size = new Size(100, 100);
            Controls.Add(picture);
            picture.Load(items.imageAlbum);
            return picture;
        }

        private ListBox AddInfoTrack(ref int inc, SpotifyTrack items, PictureBox picture)
        {
            inc += 0;
            ListBox Info = new ListBox();
            Info.Visible = true;
            Info.Location = new Point(500, picture.Location.Y);
            Info.Size = new Size(200, 60);
            Controls.Add(Info);
            Info.Items.Add("Name Song: " + items.nameSong);
            Info.Items.Add("Name Artist: " + items.nameArtist);
            Info.Items.Add("Name Album: " + items.nameAlbum);
            Info.Items.Add("Popularity: " + items.popularity);
            Info.Items.Add("Duration:" + items.duration_ms);
            return Info;
        }

        private Dictionary<PictureBox, ListBox> ShowTracks(List<SpotifyTrack> ListTracks)
        {
            int inc = 0;
            //Dictionary<PictureBox, ListBox> Map;
            InfoTrack = new Dictionary<PictureBox, ListBox>();
            foreach (var items in ListTracks)
            {
                PictureBox picture = AddPictureTrack(ref inc, items);
                ListBox listBox = AddInfoTrack(ref inc, items, picture);
                InfoTrack.Add(picture, listBox);
            }
            return InfoTrack;
        }

        private PictureBox AddPictureArtist(ref int inc, SpotifyArtist items)
        {
            inc += 100;
            PictureBox picture = new PictureBox();
            picture.Visible = true;
            picture.SizeMode = PictureBoxSizeMode.Zoom;
            picture.Location = new Point(SArtist.Location.X, SArtist.Location.Y + inc - 50);
            picture.Size = new Size(100, 100);
            Controls.Add(picture);
            picture.Load(items.Image);
            return picture;
        }

        private ListBox AddInfoArtist(ref int inc, SpotifyArtist items, PictureBox picture)
        {
            inc += 0;
            ListBox Info = new ListBox();
            Info.Visible = true;
            Info.Location = new Point(picture.Location.X + 100, picture.Location.Y);
            Info.Size = new Size(200, 60);
            Controls.Add(Info);
            Info.Items.Add("Name: " + items.Name);
            Info.Items.Add("Followers: " + items.Followers);
            Info.Items.Add("Popularity: " + items.Popularity);
            Info.Items.Add("ID: " + items.ID);
            Info.Items.Add("Genre:" + items.Genres);
            return Info;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            RemovePrevious(Info);
            RemovePrevious(InfoTrack);
            var ResultArtists = spotifySearch.SearchArtist(SArtist.Text);
            Root artists = JsonConvert.DeserializeObject<Root>(ResultArtists);

            var ResultTracks = spotifySearch.SearchTrack(SArtist.Text);
            Songs songs = JsonConvert.DeserializeObject<Songs>(ResultTracks);

            List<SpotifyArtist> ListArtists = SaveListArtist(artists);
            Info = ShowArtists(ListArtists);

            List<SpotifyTrack> ListSongs = SaveListTrack(songs);
            InfoTrack = ShowTracks(ListSongs);

        }

        private void IDPlaylist_Click(object sender, EventArgs e)
        {
            RemovePrevious(Info);
            RemovePrevious(InfoTrack);
            /*5CS8E6JVACItYto4OOJoPW*/
            /*spotify:album:270o30h7cAlEhBnbuSpFZq*/
            // showPlaylist.RemovePrevious(Info2, Controls);
            string Result = album.SearchAlbumsTracks(SPlaylist.Text);
            Playlist artists = JsonConvert.DeserializeObject<Playlist>(Result);
            List<Track> ListArtists = showPlaylist.SaveListTracks(artists);
            Info2 = showPlaylist.ShowTracks(ListArtists, SPlaylist, Controls);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RemovePrevious(Info);
            RemovePrevious(InfoTrack);
            label1.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            button3.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CreatePlaylist createPlaylist = new CreatePlaylist();
            if (textBox1.Text != null && textBox2.Text != null)
                createPlaylist.CreatePlaylistUser(textBox1.Text, textBox2.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RemovePrevious(Info);
            RemovePrevious(InfoTrack);
            label3.Visible = true;
            label4.Visible = true;
            playid.Visible = true;
            uris.Visible = true;
            button5.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //IDPLAYLIST 3yqvJk878tuTeAIF7BQPSo
            //EJEMPLO DE ROLAS spotify:track:3FAJ6O0NOHQV8Mc5Ri6ENp
            //spotify:track:1nahzW3kfMuwReTka28tH5
            AddTrackToPlayList AddTrack = new AddTrackToPlayList();
            if (uris.Text != null && playid.Text != null)
                AddTrack.AddItem(playid.Text, uris.Text);
        }
    }
}