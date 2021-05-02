using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace Spotify_API
{

    public class SpotifySearch
    {

        public class ExternalUrls
        {
            public string spotify { get; set; }
        }

        public class Artist
        {
            public ExternalUrls external_urls { get; set; }
            public string href { get; set; }
            public string id { get; set; }
            public string name { get; set; }
            public string type { get; set; }
            public string uri { get; set; }
        }

        public class Image
        {
            public int height { get; set; }
            public string url { get; set; }
            public int width { get; set; }
        }

        public class Album
        {
            public string album_type { get; set; }
            public List<Artist> artists { get; set; }
            public List<string> available_markets { get; set; }
            public ExternalUrls external_urls { get; set; }
            public string href { get; set; }
            public string id { get; set; }
            public List<Image> images { get; set; }
            public string name { get; set; }
            public string release_date { get; set; }
            public string release_date_precision { get; set; }
            public int total_tracks { get; set; }
            public string type { get; set; }
            public string uri { get; set; }
        }

        public class ExternalIds
        {
            public string isrc { get; set; }
        }

        public class Item
        {
            public Album album { get; set; }
            public List<Artist> artists { get; set; }
            public List<string> available_markets { get; set; }
            public int disc_number { get; set; }
            public int duration_ms { get; set; }
            public bool @explicit { get; set; }
            public ExternalIds external_ids { get; set; }
            public ExternalUrls external_urls { get; set; }
            public string href { get; set; }
            public string id { get; set; }
            public bool is_local { get; set; }
            public string name { get; set; }
            public int popularity { get; set; }
            public string preview_url { get; set; }
            public int track_number { get; set; }
            public string type { get; set; }
            public string uri { get; set; }
        }

        public class Tracks
        {
            public string href { get; set; }
            public List<Item> items { get; set; }
            public int limit { get; set; }
            public string next { get; set; }
            public int offset { get; set; }
            public object previous { get; set; }
            public int total { get; set; }
        }

        public class Songs
        {
            public Tracks tracks { get; set; }
        }

        public string SearchArtist(string Word)
        {
            string url = string.Format("https://api.spotify.com/v1/search?q={0}&type=artist", Word);
            string myToken = SpotifyToken.GetAccessToken("bd09b0277ece4ad1b30955a0b51c6101", "dac122b7bc304e909636cf52c0c5a037");
            try
            {
                // Get token for request
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                request.Accept = "application/json";
                request.ContentType = "application/json";
                request.Headers.Add("Authorization", "Bearer " + myToken);

                string Json;

                using (WebResponse response = request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader Reader = new StreamReader(stream))
                {
                    Json = Reader.ReadToEnd();
                    Reader.Close();
                }
                return Json;
            }

            catch (WebException ex)
            {
                Console.WriteLine("Track Request Error: " + ex.Status);
            }
            catch (TaskCanceledException tex)
            {
                Console.WriteLine("Track Request Error: " + tex.Message);
            }

            return null;
        }

        public string SearchTrack(string Word)
        {
            string url = "https://api.spotify.com/v1/search?q=" + Word + "&type=track";
            string token = SpotifyToken.GetAccessToken("bd09b0277ece4ad1b30955a0b51c6101", "dac122b7bc304e909636cf52c0c5a037");

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            request.Headers.Add("Authorization", "Bearer " + token);

            string Json;

            using (WebResponse response = request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader Reader = new StreamReader(stream))
            {
                Json = Reader.ReadToEnd();
                Reader.Close();
            }

            return Json;
        }
    }

}