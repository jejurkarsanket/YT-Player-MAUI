﻿
namespace TubePlayer.Models
{
    //Model for You Tube
    public class VideoSearchResult
    {

        [JsonPropertyName("nextPageToken")]
        public string NextPageToken { get; set; }

        [JsonPropertyName("pageInfo")]
        public PageInfo PageInfo { get; set; }

        [JsonPropertyName("items")]
        public List<YouTubeVideo> Items { get; set; }
    }

    public class PageInfo
    {
        [JsonPropertyName("totalResults")]
        public int TotalResults { get; set; }

        [JsonPropertyName("resultsPerPage")]
        public int ResultsPerPage { get; set; }
    }

    public class YouTubeVideo
    {

        [JsonPropertyName("id")]
        public Id Id { get; set; }

        [JsonPropertyName("snippet")]
        public Snippet Snippet { get; set; }
    }

    public class Id
    {

        [JsonPropertyName("videoId")]
        public string VideoId { get; set; }
    }

    public class Snippet
    {
        [JsonPropertyName("publishedAt")]
        public DateTime PublishedAt { get; set; }

        [JsonPropertyName("channelId")]
        public string ChannelId { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("thumbnails")]
        public Thumbnails Thumbnails { get; set; }

        [JsonPropertyName("channelTitle")]
        public string ChannelTitle { get; set; }

    }
    public class Thumbnails
    {
        [JsonPropertyName("medium")]
        public Thumbnail Medium { get; set; }

        [JsonPropertyName("high")]
        public Thumbnail High { get; set; }
    }

    public class Thumbnail
    {
        [JsonPropertyName("url")]
        public string Url { get; set; }

    }
}

   
