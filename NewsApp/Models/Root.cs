using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApp.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Article
    {
        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("title")]
        public string title { get; set; }

        [JsonProperty("description")]
        public string description { get; set; }

        [JsonProperty("content")]
        public string content { get; set; }

        [JsonProperty("url")]
        public string url { get; set; }

        [JsonProperty("image")]
        public string image { get; set; }

        [JsonProperty("publishedAt")]
        public DateTime publishedAt { get; set; }

        [JsonProperty("lang")]
        public string lang { get; set; }

        [JsonProperty("source")]
        public Source source { get; set; }
    }

    public class Information
    {
        [JsonProperty("realTimeArticles")]
        public RealTimeArticles realTimeArticles { get; set; }
    }

    public class RealTimeArticles
    {
        [JsonProperty("message")]
        public string message { get; set; }
    }

    public class Root
    {
        [JsonProperty("information")]
        public Information information { get; set; }

        [JsonProperty("totalArticles")]
        public int totalArticles { get; set; }

        [JsonProperty("articles")]
        public List<Article> articles { get; set; }
    }

    public class Source
    {
        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("url")]
        public string url { get; set; }
    }


}
