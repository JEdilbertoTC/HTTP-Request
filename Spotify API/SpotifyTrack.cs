using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_API
{
    class SpotifyTrack
    {
        public string nameArtist { get; set; }
        public string imageAlbum { get; set; }
        public string nameAlbum { get; set; }
        public string duration_ms { get; set; }
        public string nameSong { get; set; }
        public string @explicit { get; set; }
        public string popularity { get; set; }
    }
}
