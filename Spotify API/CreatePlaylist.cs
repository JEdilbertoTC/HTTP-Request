using System.IO;
using System.Net;
using System.Text;

namespace Spotify_API
{
    class CreatePlaylist
    {
        public void CreatePlaylistUser(string NamePlaylist, string DescriptionPlaylist)
        {
            //LINK PARA ACTUALIZAR EL TOKEN CON SCOPES
            /*https://developer.spotify.com/console/post-playlists/ */
            var Firstscope = "playlist-modify-public";

            var SecondScope = "playlist-modify-private";

            var user_id = "335auudizxhdjk2y9rsjkar0b";
            var token = "BQDyJ-WwrN-EtK6P8a7YUd8haQktW-M1J-Jv-5Q8BBID_7Dyz69Wq1puJ6e4nQV0Kr1jfEpxBUiH1MZVYCMErpc1Yu4lCzUDUMUgraBx-5eYSuHzH5p5OPHOB-eswEWjCGWgiG4e7pkvTCHYjchzHlL9jkDIQWEqb551_G5NpZp9Pc32vx8X9oHEQ-OD3H0WN0KxC5SzE0HksBeDMpgvd8Ht_S-C_o-pq8UFB7ctpmdWyUma-eQHeNXjopV35tdxilVgYLkw8wPJ3ZVxUtkKPb9zfPo80I4e0QKmKeFM";
            string url5 = string.Format("https://api.spotify.com/v1/users/{0}/playlists", user_id);
 
            string data = "{\"name\":\"" + NamePlaylist + "\",\"description\":\"" + DescriptionPlaylist + "\",\"public\":false}";

            byte[] dataBytes = Encoding.ASCII.GetBytes(data);
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url5);

            webRequest.Method = "POST";
            webRequest.ContentType = "application/json";
            webRequest.Accept = "application/json";
            webRequest.Headers.Add("Authorization", "Bearer " + token);
            webRequest.ContentLength = dataBytes.Length;

            using (Stream strm = webRequest.GetRequestStream())
            {
                strm.Write(dataBytes, 0, dataBytes.Length);
                strm.Close();
            }

            string Json;

            using (HttpWebResponse resp = (HttpWebResponse)webRequest.GetResponse())
            using (Stream respStr = resp.GetResponseStream())
            using (StreamReader Reader = new StreamReader(respStr))
            {
                Json = Reader.ReadToEnd();
                //should get back a string i can then turn to json and parse for accesstoken
                Reader.Close();
            }

        }
    }
}