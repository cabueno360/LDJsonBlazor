using System.Text.Json.Serialization;

namespace LDJson.Blazor.Generator.Model
{
    public readonly record struct AggregateRating
    {
        public static readonly AggregateRating None = new AggregateRating();

        public AggregateRating()
        {
        }

        [JsonPropertyName("@type")]
        public string Type { get; init; } = "AggregateRating";
        public double RatingValue { get; init; }
        public int RatingCount { get; init; }
        public int ReviewCount { get; init; }

        public static AggregateRating Create(double ratingValue, int ratingCount, int reviewCount) => new AggregateRating
        {
            RatingValue = ratingValue,
            RatingCount = ratingCount,
            ReviewCount = reviewCount
        };
    }
}
