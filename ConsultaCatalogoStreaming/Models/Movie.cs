using System.Text.Json.Serialization;

namespace ConsultaCatalogoStreaming.Models
{

    public class Movie
    {
        [JsonPropertyName("imdbID")]
        public string imdbID { get; set; }
        public string tmdbID { get; set; }
        //public int imdbRating { get; set; }
        //public int imdbVoteCount { get; set; }
        //public int tmdbRating { get; set; }
        //public string originalTitle { get; set; }
        //public List<int> genres { get; set; }
        //public List<string> countries { get; set; }
        //public int year { get; set; }
        //public int runtime { get; set; }
        //public List<string> cast { get; set; }
        //public List<string> significants { get; set; }
        //public string title { get; set; }
        //public string overview { get; set; }
        //public string tagline { get; set; }
        //public string video { get; set; }
        //public int age { get; set; }
        //public StreamingInfo streamingInfo { get; set; }
        //public string originalLanguage { get; set; }
    }

}
