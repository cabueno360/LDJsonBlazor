using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LDJson.Blazor.Generator.Model
{

    public readonly record struct Review
    {
        public static readonly Review None = new Review();

        public Review()
        {
        }

        [JsonPropertyName("@type")]
        public string Type { get; init; } = "Review";
        public Person Author { get; init; }
        public DateTime DatePublished { get; init; }
        public Rating ReviewRating { get; init; }

        public static Review Create(Person author, DateTime datePublished, Rating reviewRating) => new Review
        {
            Author = author,
            DatePublished = datePublished,
            ReviewRating = reviewRating
        };
    }
}
