
# Blazor LD+JSON Generator for .NET 8

## Overview

The **Blazor LD+JSON Generator** is a Blazor component designed for .NET 8 that simplifies the creation of structured data markup for Google Search. By using this package, developers can easily generate LD+JSON scripts, ensuring their web pages are optimized for search engine visibility and rich results.

## Features

- **Seamless Integration:** Easily integrate LD+JSON structured data into your Blazor applications.
- **SEO Optimization:** Enhance your web pages' search engine optimization with minimal effort.
- **Flexible Data Models:** Support for various structured data types and properties.

## Installation

You can install the package via NuGet Package Manager:

```sh
dotnet add package Blazor.LdJson
```

Or use the NuGet Package Manager Console:

```sh
Install-Package Blazor.LdJson
```

## Usage

### Component Setup

1. Add the `LdJson` component to your Blazor page:

```razor
@page "/example"
@using YourNamespace

<LdJson Data="yourLdJsonModel" />
```

2. Create and initialize an instance of `LdJsonModel` with your structured data:

```csharp
@code {
    private LdJsonModel yourLdJsonModel = LdJsonModel.Create(
        id: "course-123",
        name: "Example Course",
        description: "This is an example course.",
        publisher: new Organization { Name = "Publisher Name" },
        provider: new Organization { Name = "Provider Name" },
        image: new List<string> { "https://example.com/image1.jpg" },
        aggregateRating: new AggregateRating { RatingValue = 4.5, RatingCount = 100 },
        offers: new List<Offer> { new Offer { Price = "99.99", PriceCurrency = "USD" } },
        totalHistoricalEnrollment: 1000,
        datePublished: DateTime.Now,
        educationalLevel: "Beginner",
        about: new List<string> { "Subject1", "Subject2" },
        teaches: new List<string> { "Skill1", "Skill2" },
        financialAidEligible: "Yes",
        inLanguage: "en",
        availableLanguage: new List<string> { "en", "es" },
        syllabusSections: new List<SyllabusSection> { new SyllabusSection { Name = "Introduction" } },
        review: new List<Review> { new Review { ReviewRating = new Rating { RatingValue = 5 }, ReviewBody = "Great course!" } },
        coursePrerequisites: new List<string> { "None" },
        educationalCredentialAwarded: new List<EducationalCredentialAwarded> { new EducationalCredentialAwarded { Credential = "Certificate" } },
        video: new Video { Url = "https://example.com/video.mp4" },
        hasCourseInstance: new List<CourseInstance> { new CourseInstance { StartDate = DateTime.Now } },
        hasPart: new List<LdJsonModel> { LdJsonModel.None }
    );
}
```

### Example

```razor
@page "/example"
@using YourNamespace

<LdJson Data="yourLdJsonModel" />

@code {
    private LdJsonModel yourLdJsonModel = LdJsonModel.Create(
        id: "course-123",
        name: "Example Course",
        description: "This is an example course.",
        publisher: new Organization { Name = "Publisher Name" },
        provider: new Organization { Name = "Provider Name" },
        image: new List<string> { "https://example.com/image1.jpg" },
        aggregateRating: new AggregateRating { RatingValue = 4.5, RatingCount = 100 },
        offers: new List<Offer> { new Offer { Price = "99.99", PriceCurrency = "USD" } },
        totalHistoricalEnrollment: 1000,
        datePublished: DateTime.Now,
        educationalLevel: "Beginner",
        about: new List<string> { "Subject1", "Subject2" },
        teaches: new List<string> { "Skill1", "Skill2" },
        financialAidEligible: "Yes",
        inLanguage: "en",
        availableLanguage: new List<string> { "en", "es" },
        syllabusSections: new List<SyllabusSection> { new SyllabusSection { Name = "Introduction" } },
        review: new List<Review> { new Review { ReviewRating = new Rating { RatingValue = 5 }, ReviewBody = "Great course!" } },
        coursePrerequisites: new List<string> { "None" },
        educationalCredentialAwarded: new List<EducationalCredentialAwarded> { new EducationalCredentialAwarded { Credential = "Certificate" } },
        video: new Video { Url = "https://example.com/video.mp4" },
        hasCourseInstance: new List<CourseInstance> { new CourseInstance { StartDate = DateTime.Now } },
        hasPart: new List<LdJsonModel> { LdJsonModel.None }
    );
}
```

