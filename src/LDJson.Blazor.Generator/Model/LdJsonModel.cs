using System.Text.Json.Serialization;
using System;
using LDJson.Blazor.Generator.Model;

namespace LDJson.Blazor.Generator
{
    public record LdJsonModel
    {
        public static readonly LdJsonModel None = new LdJsonModel();

        public LdJsonModel()
        {
        }

        [JsonPropertyName("@context")]
        public string Context { get; init; } = "https://schema.org/";

        [JsonPropertyName("@id")]
        public string Id { get; init; }

        [JsonPropertyName("@type")]
        public string Type { get; init; } = "Course";

        public string Name { get; init; }
        public string Description { get; init; }
        public Organization Publisher { get; init; }
        public Organization Provider { get; init; }
        public List<string> Image { get; init; }
        public AggregateRating AggregateRating { get; init; }
        public List<Offer> Offers { get; init; }
        public int TotalHistoricalEnrollment { get; init; }
        public DateTime DatePublished { get; init; }
        public string EducationalLevel { get; init; }
        public List<string> About { get; init; }
        public List<string> Teaches { get; init; }
        public string FinancialAidEligible { get; init; }
        public string InLanguage { get; init; }
        public List<string> AvailableLanguage { get; init; }
        public List<SyllabusSection> SyllabusSections { get; init; }
        public List<Review> Review { get; init; }
        public List<string> CoursePrerequisites { get; init; }
        public List<EducationalCredentialAwarded> EducationalCredentialAwarded { get; init; }
        public Video Video { get; init; }
        public List<CourseInstance> HasCourseInstance { get; init; }
        public List<LdJsonModel> HasPart { get; init; }

        public static LdJsonModel Create(
            string id,
            string name,
            string description,
            Organization publisher,
            Organization provider,
            List<string> image,
            AggregateRating aggregateRating,
            List<Offer> offers,
            int totalHistoricalEnrollment,
            DateTime datePublished,
            string educationalLevel,
            List<string> about,
            List<string> teaches,
            string financialAidEligible,
            string inLanguage,
            List<string> availableLanguage,
            List<SyllabusSection> syllabusSections,
            List<Review> review,
            List<string> coursePrerequisites,
            List<EducationalCredentialAwarded> educationalCredentialAwarded,
            Video video,
            List<CourseInstance> hasCourseInstance,
            List<LdJsonModel> hasPart) => new LdJsonModel
            {
                Id = id,
                Name = name,
                Description = description,
                Publisher = publisher,
                Provider = provider,
                Image = image,
                AggregateRating = aggregateRating,
                Offers = offers,
                TotalHistoricalEnrollment = totalHistoricalEnrollment,
                DatePublished = datePublished,
                EducationalLevel = educationalLevel,
                About = about,
                Teaches = teaches,
                FinancialAidEligible = financialAidEligible,
                InLanguage = inLanguage,
                AvailableLanguage = availableLanguage,
                SyllabusSections = syllabusSections,
                Review = review,
                CoursePrerequisites = coursePrerequisites,
                EducationalCredentialAwarded = educationalCredentialAwarded,
                Video = video,
                HasCourseInstance = hasCourseInstance,
                HasPart = hasPart
            };
    }
}
