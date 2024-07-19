using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LDJson.Blazor.Generator.Model
{
    public readonly record struct CourseInstance
    {
        public static readonly CourseInstance None = new CourseInstance();

        public CourseInstance()
        {
        }

        [JsonPropertyName("@type")]
        public string Type { get; init; } = "CourseInstance";
        public string CourseMode { get; init; }
        public string Location { get; init; }
        public Schedule CourseSchedule { get; init; }
        public string CourseWorkload { get; init; }

        public static CourseInstance Create(
            string courseMode,
            string location,
            Schedule courseSchedule,
            string courseWorkload) => new CourseInstance()
            {
                CourseMode = courseMode,
                Location = location,
                CourseSchedule = courseSchedule,
                CourseWorkload = courseWorkload
            };
    }
}
