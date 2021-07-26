using System.Collections.Generic;
using Newtonsoft.Json;

namespace GDBrowser.Models.Gauntlets
{
    public class Gauntlets
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("levels")]
        public List<string> Levels { get; set; }
    }
}
