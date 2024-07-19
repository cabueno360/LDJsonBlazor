using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LDJson.Blazor.Generator
{
    public readonly record struct Organization
    {
        public static readonly Organization None = new Organization();

        public Organization()
        {
        }

        public Organization(string type, string name, string url)
        {
            Type = type;
            Name = name;
            Url = url;
        }

        [JsonPropertyName("@type")]
        public string Type { get; init; } = "Organization";

        public string Name { get; init; }
        public string Url { get; init; }

        public static Organization Create(string name, string url) => new Organization
        {
            Name = name,
            Url = url
        };
    }


    




    public readonly record struct Rating
    {
        public static readonly Rating None = new Rating();

        public Rating()
        {
        }
        [JsonPropertyName("@type")]
        public string Type { get; init; } = "Rating";
        public int BestRating { get; init; }
        public double RatingValue { get; init; }

        public static Rating Create(int bestRating, double ratingValue) => new Rating
        {
            BestRating = bestRating,
            RatingValue = ratingValue
        };
    }


    

    public readonly record struct Schedule
    {
        public static readonly Schedule None = new Schedule();

        public Schedule()
        {
        }

        [JsonPropertyName("@type")]
        public string Type { get; init; } = "Schedule";
        public string Duration { get; init; }
        public string RepeatFrequency { get; init; }
        public int RepeatCount { get; init; }
        public DateTime StartDate { get; init; }
        public DateTime EndDate { get; init; }

        public static Schedule Create(
            string duration,
            string repeatFrequency,
            int repeatCount,
            DateTime startDate,
            DateTime endDate) => new Schedule
            {
                Duration = duration,
                RepeatFrequency = repeatFrequency,
                RepeatCount = repeatCount,
                StartDate = startDate,
                EndDate = endDate
            };
    }
}
