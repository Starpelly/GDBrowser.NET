using System.Collections.Generic;
using Newtonsoft.Json;

namespace GDBrowser.Models.Leaderboard
{
    public class Leaderboard
    {
        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("playerID")]
        public int PlayerID { get; set; }

        [JsonProperty("accountID")]
        public int AccountID { get; set; }

        [JsonProperty("stars")]
        public int Stars { get; set; }

        [JsonProperty("demons")]
        public int Demons { get; set; }

        [JsonProperty("cp")]
        public int CreatorPoints { get; set; }

        [JsonProperty("coins")]
        public int Coins { get; set; } // Star Coins

        [JsonProperty("usercoins")]
        public int UserCoins { get; set; }

        [JsonProperty("diamonds")]
        public int Diamonds { get; set; }

        [JsonProperty("icon")]
        public Icon Icon { get; set; }
    }

    public class Icon
    {

        [JsonProperty("form")]
        public string Form { get; set; }

        [JsonProperty("icon")]
        public int IconID { get; set; } // This one is confusing, this is actually the icon ID but the one on the profile is the cube, yeah idk either.

        [JsonProperty("col1")]
        public int Colour1 { get; set; }

        [JsonProperty("col2")]
        public int Colour2 { get; set; }

        [JsonProperty("glow")]
        public bool Glow { get; set; }
    }
}
