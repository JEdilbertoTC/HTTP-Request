using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace Spotify_API
{
    class AddTrackToPlayList
    {
        public void AddItem(string playlist_id, string uris)
        {

            string url = "https://api.spotify.com/v1/playlists/" + playlist_id + "/tracks?" + "uris=" + uris;
            string token = "BQDyJ-WwrN-EtK6P8a7YUd8haQktW-M1J-Jv-5Q8BBID_7Dyz69Wq1puJ6e4nQV0Kr1jfEpxBUiH1MZVYCMErpc1Yu4lCzUDUMUgraBx-5eYSuHzH5p5OPHOB-eswEWjCGWgiG4e7pkvTCHYjchzHlL9jkDIQWEqb551_G5NpZp9Pc32vx8X9oHEQ-OD3H0WN0KxC5SzE0HksBeDMpgvd8Ht_S-C_o-pq8UFB7ctpmdWyUma-eQHeNXjopV35tdxilVgYLkw8wPJ3ZVxUtkKPb9zfPo80I4e0QKmKeFM";
            List<string> scope = new List<string>();
            scope.Add("user-read-private");
            //var token = SpotifyToken.GetAccessToken("bd09b0277ece4ad1b30955a0b51c6101", "dac122b7bc304e909636cf52c0c5a037");
            string data = "Mensaje de prueba";
            byte[] dataByte = Encoding.ASCII.GetBytes(data);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            request.Headers.Add("Authorization", "Bearer " + token);
            request.ContentLength = dataByte.Length;

            using (Stream response = request.GetRequestStream())
            {
                response.Write(dataByte, 0, dataByte.Length);
                response.Close();
            }

        }
    }
}