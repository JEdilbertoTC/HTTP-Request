using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Spotify_API
{
    public class SearchAlbum
    {
        public string SearchAlbumsTracks(string Word)
        {
            //https://api.spotify.com/v1/albums?ids
            string url = string.Format("https://api.spotify.com/v1/albums/{0}/tracks", Word);
            string Request = string.Empty;
            string myToken = SpotifyToken.GetAccessToken("bd09b0277ece4ad1b30955a0b51c6101", "dac122b7bc304e909636cf52c0c5a037");
            try
            {
                // Get token for request
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                request.Accept = "application/json";
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

    }
}