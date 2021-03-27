using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Spotify_API
{

    class SpotifySearch
    {
        public class ExternalUrls
        {
            public string spotify { get; set; }
        }

        public class ImageSP
        {
            public int width { get; set; }
            public string url { get; set; }
        }
        public class Album
        {
            public List<ImageSP> images { get; set; }
        }
        public class Followers
        {
            public object href { get; set; }
            public int total { get; set; }
        }

        public class Item
        {
            //public int height { get; set; }
            public ExternalUrls external_urls { get; set; }
            //public Followers followers { get; set; }
            //public List<string> genres { get; set; }
            public string href { get; set; }
            public string id { get; set; }
            public List<Album> album { get; set; }
            public string name { get; set; }
            public int popularity { get; set; }
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

        public class SpotifyResult
        {
            public Tracks tracks { get; set; }
        }
        public static SpotifyResult SearchSong(string song)
        {
            string url = string.Format("https://api.spotify.com/v1/search?q={0} &type=track&market=US&limit=10&offset=0", song);
            string Request = string.Empty;
            var spotifyArtist = new SpotifyResult();
            string myToken = SpotifyToken.GetAccessToken("bd09b0277ece4ad1b30955a0b51c6101", "dac122b7bc304e909636cf52c0c5a037");
            try
            {
                // Get token for request
                HttpClient hc = new HttpClient();
                var request = new HttpRequestMessage()
                {
                    RequestUri = new Uri(url),
                    Method = HttpMethod.Get
                };
                request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                request.Headers.Authorization = new AuthenticationHeaderValue("Authorization", "Bearer " + myToken);
                // TODO: Had a task cancelled here, too many errors. Find a better way to process this maybe.
                // Same code is in GetTrackFeatures function.
                var task = hc.SendAsync(request)
                    .ContinueWith((taskwithmsg) =>
                    {
                        var response = taskwithmsg.Result;
                        var jsonTask = response.Content.ReadAsStringAsync();
                        Request = jsonTask.Result;
                        spotifyArtist = JsonConvert.DeserializeObject<SpotifyResult>(Request);
                    });
                task.Wait();

            }
            catch (WebException ex)
            {
                Console.WriteLine("Track Request Error: " + ex.Status);
            }
            catch (TaskCanceledException tex)
            {
                Console.WriteLine("Track Request Error: " + tex.Message);
            }
            
            return spotifyArtist;
        }

    }

}