using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Spotify_API
{
    public class ShowPlaylist
    {
        Dictionary<TextBox, ListBox> Info;
        public void RemovePrevious(Dictionary<TextBox, ListBox> lists, Control.ControlCollection Controls)
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
        private ListBox AddInfoTracks(ref int inc, Track items, TextBox picture, Control.ControlCollection Controls)
        {
            inc += 100;
            ListBox Info = new ListBox();
            Info.Visible = true;
            Info.Location = new Point(picture.Location.X + 100, picture.Location.Y+inc);
            Info.Size = new Size(200, 60);
            Controls.Add(Info);
            Info.Items.Add("Artist: " + items.artist);
            Info.Items.Add("Local: " + items.is_local);
            Info.Items.Add("Disc Number: " + items.disc_number);
            Info.Items.Add("ID: " + items.id);
            Info.Items.Add("Type:" + items.type);
            Info.Items.Add("Track Number:" + items.track_number);
            Info.Items.Add("Name:" + items.name);
            Info.Items.Add("Explicit:" + items.@explicit);
            Info.Items.Add("Duration:" + items.duration_ms);
            Info.Items.Add("Available Markets:" + items.available_markets);
            return Info;
        }
        public List<Track> SaveListTracks(Playlist tracks)
        {
            var ListArtist = new List<Track>();
            foreach (var Items in tracks.items)
            {
                ListArtist.Add(new Track()
                {
                    id = Items.id,
                    artist = Items.artists[0].name,
                    name = Items.name,
                    disc_number = Items.disc_number.ToString(),
                    available_markets = Items.available_markets[0],
                    duration_ms = Items.duration_ms.ToString(),
                    @explicit = Items.@explicit.ToString(),
                    is_local = Items.is_local.ToString(),
                    track_number = Items.track_number.ToString(),
                    type = Items.type
                });
            }
            return ListArtist;
        }

        public Dictionary<TextBox, ListBox> ShowTracks(List<Track> ListArtists, TextBox picture, Control.ControlCollection Control)
        {
            int inc = 0;
            // Dictionary<PictureBox, ListBox> Map;
            Info = new Dictionary<TextBox, ListBox>();
            foreach (var items in ListArtists)
            {
                ListBox listBox = AddInfoTracks(ref inc, items, picture, Control);
               // Info.Add(picture, listBox);
            }
            return Info;
        }
    }
}
