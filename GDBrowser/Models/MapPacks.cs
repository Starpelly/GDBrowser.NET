using System.Collections.Generic;
using Newtonsoft.Json;

namespace GDBrowser.Models.MapPacks
{
    public class MapPacks
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("levels")]
        public List<string> Levels { get; set; }

        [JsonProperty("stars")]
        public int Stars { get; set; }

        [JsonProperty("coins")]
        public int Coins { get; set; }

        [JsonProperty("difficulty")]
        public string Difficulty { get; set; }

        [JsonProperty("barColor")]
        public string BarColour { get; set; }

        [JsonProperty("textColor")]
        public string TextColour { get; set; }
    }
}
