using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LDJson.Blazor.Generator.Model
{

    public readonly record struct Offer
    {
        public static readonly Offer None = new Offer();

        public Offer()
        {
        }

        [JsonPropertyName("@type")]
        public string Type { get; init; } = "Offer";
        public string Category { get; init; }
        public string PriceCurrency { get; init; }
        public double Price { get; init; }

        public static Offer Create(string category, string priceCurrency, double price) => new Offer
        {
            Category = category,
            PriceCurrency = priceCurrency,
            Price = price
        };
    }
}
