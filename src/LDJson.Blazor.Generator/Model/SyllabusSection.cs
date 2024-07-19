using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LDJson.Blazor.Generator.Model
{

    public readonly record struct SyllabusSection
    {
        public static readonly SyllabusSection None = new SyllabusSection();

        public SyllabusSection()
        {
        }

        [JsonPropertyName("@type")]
        public string Type { get; init; } = "Syllabus";
        public string Name { get; init; }
        public string Description { get; init; }
        public string TimeRequired { get; init; }

        public static SyllabusSection Create(string name, string description, string timeRequired) => new SyllabusSection
        {
            Name = name,
            Description = description,
            TimeRequired = timeRequired
        };
    }

}
