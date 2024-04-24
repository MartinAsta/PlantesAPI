namespace Plantes
{
    using System.Text.Json;
    public class PlantesData
    {
        public int? ID { get; set; }
        public string? Common_Name { get; set; }
        public string? Slug { get; set; }
        public string? Scientific_Name { get; set; }
        public int? Year { get; set; }
        public string? Bibliography { get; set; }
        public string? Author { get; set; }
        public string? Status { get; set; }
        public string? Rank { get; set; }
        public string? Family_Common_Name { get; set; }
        public int? Genus_ID { get; set; }
        public string? Image_URL { get; set; }
        public List<string>? Synonyms { get; set; }
        public string? Genus { get; set; }
        public string? Family { get; set; }
        public PlantesDataLink? Links { get; set; }

        public PlantesData? DeserializeFav(string json)
        {
            var planteInfos = JsonSerializer.Deserialize<PlantesData>(json, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            return planteInfos;
        }
    }
}
