using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LDJson.Blazor.Generator.Model
{

    public readonly record struct EducationalCredentialAwarded
    {
        public static readonly EducationalCredentialAwarded None = new EducationalCredentialAwarded();

        public EducationalCredentialAwarded()
        {
        }

        [JsonPropertyName("@type")]
        public string Type { get; init; } = "EducationalOccupationalCredential";
        public string Name { get; init; }
        public string Url { get; init; }
        public string CredentialCategory { get; init; }
        public List<Offer> Offers { get; init; }

        public static EducationalCredentialAwarded Create(
            string name,
            string url,
            string credentialCategory,
            List<Offer> offers) => new EducationalCredentialAwarded
            {
                Name = name,
                Url = url,
                CredentialCategory = credentialCategory,
                Offers = offers
            };
    }
}
