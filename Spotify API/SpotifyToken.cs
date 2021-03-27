using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_API
{
    class SpotifyToken
    {

        public string Access_token { get; set; }
        public string Token_type { get; set; }
        public int Expires_in { get; set; }

        public static string GetAccessToken(string ClientID, string ClientSecret)
        {
            SpotifyToken token = new SpotifyToken();
            string url5 = "https://accounts.spotify.com/api/token";

            var encode_clientid_clientsecret = Convert.ToBase64String(Encoding.UTF8.GetBytes(string.Format("{0}:{1}", ClientID, ClientSecret)));

            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url5);

            webRequest.Method = "POST";
            webRequest.ContentType = "application/x-www-form-urlencoded";
            webRequest.Accept = "application/json";
            webRequest.Headers.Add("Authorization: Basic " + encode_clientid_clientsecret);

            var request = ("grant_type=client_credentials");
            byte[] req_bytes = Encoding.ASCII.GetBytes(request);
            webRequest.ContentLength = req_bytes.Length;

            using (Stream strm = webRequest.GetRequestStream())
            {
                strm.Write(req_bytes, 0, req_bytes.Length);
                strm.Close();
            }

            string Json = "";

            using (HttpWebResponse resp = (HttpWebResponse)webRequest.GetResponse())
            using (Stream respStr = resp.GetResponseStream())
            using (StreamReader Reader = new StreamReader(respStr, Encoding.UTF8))
            {
                Json = Reader.ReadToEnd();
                //should get back a string i can then turn to json and parse for accesstoken
                Reader.Close();
            }

            token = JsonConvert.DeserializeObject<SpotifyToken>(Json);
            return token.Access_token;
        }
    }
}
