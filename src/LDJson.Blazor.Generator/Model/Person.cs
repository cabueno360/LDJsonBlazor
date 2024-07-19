using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LDJson.Blazor.Generator.Model
{

    public readonly record struct Person
    {
        public static readonly Person None = new Person();

        public Person()
        {
        }

        [JsonPropertyName("@type")]
        public string Type { get; init; } = "Person";
        public string Name { get; init; }

        public static Person Create(string name) => new Person
        {
            Name = name
        };
    }
}
