using System.Text.Json.Serialization;

namespace TheTourGuyTest.Tests.JsonModel
{
    public class StarwarsCharacterContainerJsonModel
    {
        [JsonPropertyName("starwars_character")]
        public StarwarsCharacterJsonModel StarwarsCharacter { get; set; }

    }
}

