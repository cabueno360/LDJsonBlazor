using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LDJson.Blazor.Generator.Model
{

    public readonly record struct Video
    {
        public static readonly Video None = new Video();

        public Video()
        {
        }
        [JsonPropertyName("@type")]
        public string Type { get; init; } = "VideoObject";
        public string Name { get; init; }
        public string Description { get; init; }
        public DateTime UploadDate { get; init; }
        public string ContentUrl { get; init; }
        public string ThumbnailUrl { get; init; }

        public static Video Create(
            string name,
            string description,
            DateTime uploadDate,
            string contentUrl,
            string thumbnailUrl) => new Video
            {
                Name = name,
                Description = description,
                UploadDate = uploadDate,
                ContentUrl = contentUrl,
                ThumbnailUrl = thumbnailUrl
            };
    }

}
