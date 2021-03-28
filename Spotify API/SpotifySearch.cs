using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using static Spotify_API.Spotify;

namespace Spotify_API
{

    class SpotifySearch
    {
        public class SpotifyResult
        {
            public Paging artists { get; set; }
        }

        public SpotifyResult SearchArtist(string Word)
        {
            string url = string.Format("https://api.spotify.com/v1/search?q={0}&type=artist", Word);
            string Request = string.Empty;
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
                var task = hc.SendAsync(request).ContinueWith((taskwithmsg) =>
                {
                    var response = taskwithmsg.Result;
                    var jsonTask = response.Content.ReadAsStringAsync();
                    Request = jsonTask.Result;
                    SpotifyResult spotifyArtist = JsonSerializer.Deserialize<SpotifyResult>(Request, new JsonSerializerOptions()
                    {
                        PropertyNameCaseInsensitive = true
                    });
                    return spotifyArtist;
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

            return null;
        }

    }

}