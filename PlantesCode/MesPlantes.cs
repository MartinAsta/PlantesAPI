namespace Plantes
{
    using System.Text.Json;
    public class MesPlantes
    {
        public List<PlantesData>? Data { get; set; }
        public PlantesLink? Links { get; set; }
        public PlantesMeta? Meta { get; set; }

        public MesPlantes? DeserializeUsingGenericSystemTextJson(string json)
        {
            var mesPlantes = JsonSerializer.Deserialize<MesPlantes>(json, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            return mesPlantes;
        }
    }
}
