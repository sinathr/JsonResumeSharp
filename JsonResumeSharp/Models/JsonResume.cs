// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//    
//    VERSION 0.0.0
//
//    var jsonResume = JsonResume.FromJson(jsonString);

namespace JsonResumeSharp
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// The JsonResume object based on https://jsonresume.org/schema/
    /// </summary>
    public partial class JsonResume
    {
        [JsonProperty("basics")]
        public Basics Basics { get; set; }

        [JsonProperty("work")]
        public List<Work> Works { get; set; }

        [JsonProperty("volunteer")]
        public List<Volunteer> Volunteers { get; set; }

        [JsonProperty("education")]
        public List<Education> Educations { get; set; }

        [JsonProperty("awards")]
        public List<Award> Awards { get; set; }

        [JsonProperty("publications")]
        public List<Publication> Publications { get; set; }

        [JsonProperty("skills")]
        public List<Skill> Skills { get; set; }

        [JsonProperty("languages")]
        public List<Language> Languages { get; set; }

        [JsonProperty("interests")]
        public List<Interest> Interests { get; set; }

        [JsonProperty("references")]
        public List<Reference> References { get; set; }
    }

    public partial class Award
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("awarder")]
        public string Awarder { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }
    }

    public partial class Basics
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("picture")]
        public string Picture { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("profiles")]
        public List<Profile> Profiles { get; set; }
    }

    public partial class Location
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }
    }

    public partial class Profile
    {
        [JsonProperty("network")]
        public string Network { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public partial class Education
    {
        [JsonProperty("institution")]
        public string Institution { get; set; }

        [JsonProperty("area")]
        public string Area { get; set; }

        [JsonProperty("studyType")]
        public string StudyType { get; set; }

        [JsonProperty("startDate")]
        public DateTimeOffset StartDate { get; set; }

        [JsonProperty("endDate")]
        public DateTimeOffset EndDate { get; set; }

        [JsonProperty("gpa")]
        public string Gpa { get; set; }

        [JsonProperty("courses")]
        public List<string> Courses { get; set; }
    }

    public partial class Interest
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("keywords")]
        public List<string> Keywords { get; set; }
    }

    public partial class Language
    {
        [JsonProperty("language")]
        public string LanguageLanguage { get; set; }

        [JsonProperty("fluency")]
        public string Fluency { get; set; }
    }

    public partial class Publication
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("publisher")]
        public string Publisher { get; set; }

        [JsonProperty("releaseDate")]
        public DateTimeOffset ReleaseDate { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }
    }

    public partial class Reference
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("reference")]
        public string ReferenceReference { get; set; }
    }

    public partial class Skill
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("level")]
        public string Level { get; set; }

        [JsonProperty("keywords")]
        public List<string> Keywords { get; set; }
    }

    public partial class Volunteer
    {
        [JsonProperty("organization", NullValueHandling = NullValueHandling.Ignore)]
        public string Organization { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("startDate")]
        public DateTimeOffset StartDate { get; set; }

        [JsonProperty("endDate")]
        public DateTimeOffset EndDate { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("highlights")]
        public List<string> Highlights { get; set; }

        [JsonProperty("company", NullValueHandling = NullValueHandling.Ignore)]
        public string Company { get; set; }
    }

    public partial class Work
    {
        [JsonProperty("organization", NullValueHandling = NullValueHandling.Ignore)]
        public string Organization { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("startDate")]
        public DateTimeOffset StartDate { get; set; }

        [JsonProperty("endDate")]
        public DateTimeOffset EndDate { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("highlights")]
        public List<string> Highlights { get; set; }

        [JsonProperty("company", NullValueHandling = NullValueHandling.Ignore)]
        public string Company { get; set; }
    }

    public partial class JsonResume
    {
        /// <summary>
        /// Create a JsonResume object from json string
        /// </summary>
        /// <param name="json">the json string</param>
        /// <returns></returns>
        public static JsonResume FromJson(string json) => JsonConvert.DeserializeObject<JsonResume>(json, Converter.Settings);
    }

    public static class Serialize
    {
        /// <summary>
        /// Convert the JsonResume object to json
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        public static string ToJson(this JsonResume self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
