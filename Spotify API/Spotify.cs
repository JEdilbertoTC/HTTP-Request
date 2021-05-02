/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_API
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Spotify_API
    {
        class Spotify
        {
            public class Album
            {
                public string album_type { get; set; }
                public List<Artist> artists { get; set; }
                public List<string> available_markets { get; set; }
                public List<Copyright> copyrights { get; set; }
                public ExternalId external_ids { get; set; }
                public ExternalUrl external_urls { get; set; }
                public List<string> genres { get; set; }
                public string href { get; set; }
                public string id { get; set; }
                public List<Image> images { get; set; }
                public string label { get; set; }
                public string name { get; set; }
                public int popularity { get; set; }
                public string release_date { get; set; }
                public string release_date_precision { get; set; }
                public AlbumRestriction restrictions { get; set; }
                public List<SimplifiedTrack> tracks { get; set; }
                public string type { get; set; }
                public string uri { get; set; }
            }
            public class AlbumRestriction
            {
                public string market { get; set; }
                public string product { get; set; }
                public string expliciwt { get; set; }
            }
            public class Artist
            {
                public ExternalUrl external_urls { get; set; }
                public Followers followers { get; set; }
                public List<string> genres { get; set; }
                public string href { get; set; }
                public string id { get; set; }
                public List<Image> images { get; set; }
                public string name { get; set; }
                public int popularity { get; set; }
                public string type { get; set; }
                public string uri { get; set; }
            }
            public class AudioFeatures
            {
                public float acousticness { get; set; }
                public string analysis_url { get; set; }
                public float danceability { get; set; }
                public int duration_ms { get; set; }
                public float energy { get; set; }
                public string id { get; set; }
                public float instrumentalness { get; set; }
                public int key { get; set; }
                public float liveness { get; set; }
                public float loudness { get; set; }
                public int mode { get; set; }
                public float speechiness { get; set; }
                public float tempo { get; set; }
                public int time_signature { get; set; }
                public string track_href { get; set; }
                public string type { get; set; }
                public string uri { get; set; }
                public float valence { get; set; }
            }
            public class Category
            {
                public string href { get; set; }
                public List<Image> icons { get; set; }
                public string id { get; set; }
                public string name { get; set; }
            }
            public class Context
            {
                public ExternalUrl external_urls { get; set; }
                public string href { get; set; }
                public string type { get; set; }
                public string uri { get; set; }
            }
            public class Copyright
            {
                public string text { get; set; }
                public string type { get; set; }
            }
            public class CurrentlyPlayingContext
            {
                public Disallows actions { get; set; }
                public Context context { get; set; }
                public string currently_playing_type { get; set; }
                public Device device { get; set; }
                public bool is_playing { get; set; }
                public Episode item { get; set; }
                public int progress_ms { get; set; }
                public string repeat_state { get; set; }
                public string shuffle_state { get; set; }
                public int timestamp { get; set; }
            }
            public class CurrentlyPlaying
            {
                public Context context { get; set; }
                public string currently_playing_type { get; set; }
                public bool is_playing { get; set; }
                public Episode item { get; set; }
                public int progress_ms { get; set; }
                public int timestamp { get; set; }
            }
            public class Cursor
            {
                public string after { get; set; }
            }
            public class CursorPaging
            {
                public Cursor cursors { get; set; }
                public string href { get; set; }
                public List<Object> items { get; set; }
                public int limit { get; set; }
                public string next { get; set; }
                public int total { get; set; }
            }
            public class Device
            {
                public string id { get; set; }
                public bool is_active { get; set; }
                public bool is_private_session { get; set; }
                public bool is_restricted { get; set; }
                public string name { get; set; }
                public string type { get; set; }
                public int volume_percent { get; set; }
            }
            public class Devices
            {
                public List<Device> devices { get; set; }
            }
            public class Disallows
            {
                public bool interrupting_playback { get; set; }
                public bool pausing { get; set; }
                public bool resuming { get; set; }
                public bool seeking { get; set; }
                public bool skipping_next { get; set; }
                public bool skipping_prev { get; set; }
                public bool toggling_repeat_context { get; set; }
                public bool toggling_repeat_track { get; set; }
                public bool toggling_shuffle { get; set; }
                public bool transferring_playback { get; set; }
            }
            public class Episode
            {
                public string audio_preview_url { get; set; }
                public string description { get; set; }
                public int duration_ms { get; set; }
                public bool Explicit { get; set; }
                public ExternalUrl external_urls { get; set; }
                public string href { get; set; }
                public string id { get; set; }
                public List<Image> images { get; set; }
                public bool is_externally_hosted { get; set; }
                public bool is_playable { get; set; }
                public string language { get; set; }
                public List<string> languages { get; set; }
                public string name { get; set; }
                public string release_date { get; set; }
                public string release_date_precision { get; set; }
                public ResumePoint resume_point { get; set; }
                public SimplifiedShow show { get; set; }
                public string type { get; set; }
                public string uri { get; set; }
            }
            public class Error
            {
                public string message { get; set; }
                public int status { get; set; }
            }
            public class ExplicitContentSettings
            {
                public bool filter_enabled { get; set; }
                public bool filter_locked { get; set; }
            }
            public class ExternalId
            {
                public string ean { get; set; }
                public string isrc { get; set; }
                public string upc { get; set; }
            }
            public class ExternalUrl
            {
                public string spotify { get; set; }
            }
            public class Followers
            {
                public string href { get; set; }
                public int total { get; set; }
            }
            public class Image
            {
                public int height { get; set; }
                public string url { get; set; }
                public int width { get; set; }

            }
            public class LinkedTrack
            {
                public ExternalUrl external_urls { get; set; }
                public string href { get; set; }
                public string id { get; set; }
                public string type { get; set; }
                public string uri { get; set; }
            }
            public class Paging
            {
                public string href { get; set; }
                public List<object> items { get; set; }
                public int limit { get; set; }
                public string next { get; set; }
                public int offset { get; set; }
                public string previous { get; set; }
                public int total { get; set; }
            }
            public class PlayHistory
            {
                public Context context { get; set; }
                public /*Timestamp*/ //TimeSpan played_at { get; set; }
           /*     public SimplifiedTrack track { get; set; }
            }
            public class PlayerError
            {
                public string message { get; set; }
            }
            public class Playlist
            {
                public bool collaborative { get; set; }
                public string description { get; set; }
                public ExternalUrl external_urls { get; set; }
                public Followers followers { get; set; }
                public string href { get; set; }
                public string id { get; set; }
                public List<Image> images { get; set; }
                public string name { get; set; }
                public PublicUser owner { get; set; }
                public bool Public { get; set; }
                public string snapshot_id { get; set; }
                public List<PlaylistTrack> tracks { get; set; }
                public string type { get; set; }
                public string uri { get; set; }
            }*/
            //public class PlaylistTrack
            //{
             //   public /*Timestamp*/ TimeSpan added_at { get; set; }
                //public PublicUser added_by { get; set; }
               // public bool is_local { get; set; }
             //   public Episode track { get; set; }
           // }
           /* public class PlaylistTracksRef
            {
                public string href { get; set; }
                public int total { get; set; }
            }
            public class PrivateUser
            {
                public string country { get; set; }
                public string display_name { get; set; }
                public string email { get; set; }
                public ExplicitContentSettings explicit_content { get; set; }
                public ExternalUrl external_urls { get; set; }
                public Followers followers { get; set; }
                public string href { get; set; }
                public string id { get; set; }
                public List<Image> images { get; set; }
                public string product { get; set; }
                public string type { get; set; }
                public string uri { get; set; }
            }
            public class PublicUser
            {
                public string display_name { get; set; }
                public ExternalUrl external_urls { get; set; }
                public Followers followers { get; set; }
                public string href { get; set; }
                public string id { get; set; }
                List<Image> images { get; set; }
                public string type { get; set; }
                public string uri { get; set; }
            }
            public class RecommendationSeed
            {
                public int afterFilteringSize { get; set; }
                public int afterRelinkingSize { get; set; }
                public string href { get; set; }
                public string id { get; set; }
                public int initialPoolSize { get; set; }
                public string type { get; set; }
            }
            public class Recommendations
            {
                public List<RecommendationSeed> seeds { get; set; }
                public List<SimplifiedTrack> tracks { get; set; }
            }
            public class ResumePoint
            {
                public bool fully_played { get; set; }
                public int resume_position_ms { get; set; }
            }*/
            //public class SavedAlbum
           // {
                /*Timestamp*/
              //  public TimeSpan added_at { get; set; }
                //public Album album { get; set; }

            //}
            //public class SavedEpisode
            //{
                /*TimeSpamp*/
               // public TimeSpan added_at { get; set; }
             //   public Episode episode { get; set; }
           // }
           // public class SavedShow
          //  {
                /*Timestamp*/
        //        public TimeSpan added_at { get; set; }
      //          public SimplifiedShow show { get; set; }

    //        }
          /*  public class SavedTrack
            {
                /*Timestamp*/
               // public TimeSpan added_at { get; set; }
             //   public Track track { get; set; }
           // }
        /*    public class Show
            {
                public List<string> available_markets { get; set; }
                public List<Copyright> copyrights { get; set; }
                public string description { get; set; }
                public List<SimplifiedEpisode> episodes { get; set; }
                public bool Explicit { get; set; }
                public ExternalUrl external_urls { get; set; }
                public string href { get; set; }
                public string id { get; set; }
                public List<Image> images { get; set; }
                public bool is_externally_hosted { get; set; }
                public List<string> languages { get; set; }
                public string media_type { get; set; }
                public string name { get; set; }
                public string publisher { get; set; }
                public string type { get; set; }
                public string uri { get; set; }
            }
            public class SimplifiedAlbum
            {
                public string album_group { get; set; }
                public string album_type { get; set; }
                public List<SimplifiedArtist> artists { get; set; }
                public List<string> available_markets { get; set; }
                public ExternalUrl external_urls { get; set; }
                public string href { get; set; }
                public string id { get; set; }
                public List<Image> images { get; set; }
                public string name { get; set; }
                public string release_date { get; set; }
                public string release_date_precision { get; set; }
                public AlbumRestriction restrictions { get; set; }
                public string type { get; set; }
                public string uri { get; set; }
            }
            public class SimplifiedArtist
            {
                public ExternalUrl external_urls { get; set; }
                public string href { get; set; }
                public string id { get; set; }
                public string name { get; set; }
                public string type { get; set; }
                public string uri { get; set; }
            }
            public class SimplifiedEpisode
            {
                public string audio_preview_url { get; set; }
                public string description { get; set; }
                public int duration_ms { get; set; }
                public bool Explicit { get; set; }
                public ExternalUrl external_urls { get; set; }
                public string href { get; set; }
                public string id { get; set; }
                public List<Image> images { get; set; }
                public bool is_externally_hosted { get; set; }
                public bool is_playable { get; set; }
                public string language { get; set; }
                public List<string> languages { get; set; }
                public string name { get; set; }
                public string release_date { get; set; }
                public string release_date_precision { get; set; }
                public ResumePoint resume_point { get; set; }
                public string type { get; set; }
                public string uri { get; set; }
            }
            public class SimplifiedPlaylist
            {
                public bool collaborative { get; set; }
                public string description { get; set; }
                public ExternalUrl external_urls { get; set; }
                public string href { get; set; }
                public string id { get; set; }
                public List<Image> images { get; set; }
                public string name { get; set; }
                public PublicUser owner { get; set; }
                public bool Public { get; set; }
                public string snapshot_id { get; set; }
                public PlaylistTracksRef tracks { get; set; }
                public string type { get; set; }
                public string uri { get; set; }

            }
            public class SimplifiedShow
            {
                public List<string> available_markets { get; set; }
                public List<Copyright> copyrights { get; set; }
                public string description { get; set; }
                public bool Explicit { get; set; }
                public ExternalUrl external_urls { get; set; }
                public string href { get; set; }
                public string id { get; set; }
                public List<Image> images { get; set; }
                public bool is_externally_hosted { get; set; }
                public List<string> languages { get; set; }
                public string media_type { get; set; }
                public string name { get; set; }
                public string publisher { get; set; }
                public string type { get; set; }
                public string uri { get; set; }
            }
            public class SimplifiedTrack
            {
                public List<SimplifiedArtist> artists { get; set; }
                public List<string> available_markets { get; set; }
                public int disc_number { get; set; }
                public int duration_ms { get; set; }
                public bool Explicit { get; set; }
                public ExternalUrl external_urls { get; set; }
                public string href { get; set; }
                public string id { get; set; }
                public bool is_local { get; set; }
                public bool is_playable { get; set; }
                public LinkedTrack linked_from { get; set; }
                public string name { get; set; }
                public string preview_url { get; set; }
                public TrackRestriction restrictions { get; set; }
                public int track_number { get; set; }
                public string type { get; set; }
                public string uri { get; set; }
            }
            public class Track
            {
                public SimplifiedAlbum album { get; set; }
                public List<Artist> artists { get; set; }
                public List<string> available_markets { get; set; }
                public int disc_number { get; set; }
                public int duration_ms { get; set; }
                public bool Explicit { get; set; }
                public ExternalId external_ids { get; set; }
                public ExternalUrl external_urls { get; set; }
                public string href { get; set; }
                public string id { get; set; }
                public bool is_local { get; set; }
                public bool is_playable { get; set; }
                public string linked_from { get; set; }
                public string name { get; set; }
                public int popularity { get; set; }
                public string preview_url { get; set; }
                public TrackRestriction restrictions { get; set; }
                public int track_number { get; set; }
                public string type { get; set; }
                public string uri { get; set; }
            }
            public class TrackRestriction
            {
                public string market { get; set; }
                public string product { get; set; }
                public string Explicit { get; set; }
            }
            public class TuneableTrack
            {
                public float acousticness { get; set; }
                public float danceability { get; set; }
                public int duration_ms { get; set; }
                public float energy { get; set; }
                public float instrumentalness { get; set; }
                public int key { get; set; }
                public float liveness { get; set; }
                public float loudness { get; set; }
                public int mode { get; set; }
                public float popularity { get; set; }
                public float speechiness { get; set; }
                public float tempo { get; set; }
                public int time_signature { get; set; }
                public float valence { get; set; }
            }

        }
    }
}
*/