using System.Collections.Generic;
using Newtonsoft.Json;

namespace GDBrowser.Models.Profile
{
    public class Profile
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("playerID")]
        public int PlayerID { get; set; }

        [JsonProperty("accountID")]
        public int AccountID { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("stars")]
        public int Stars { get; set; }

        [JsonProperty("diamonds")]
        public int Diamonds { get; set; }

        [JsonProperty("coins")]
        public int Coins { get; set; } // Star Coins

        [JsonProperty("userCoins")]
        public int UserCoins { get; set; }

        [JsonProperty("demons")]
        public int Demons { get; set; }

        [JsonProperty("cp")]
        public int CreatorPoints { get; set; }

        [JsonProperty("friendRequests")]
        public bool FriendRequests { get; set; }

        [JsonProperty("messages")]
        public string Messages { get; set; }

        [JsonProperty("commentHistory")]
        public string CommentHistory { get; set; }

        [JsonProperty("moderator")]
        public int Moderator { get; set; }

        [JsonProperty("youtube")]
        public string YouTube { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("twitch")]
        public string Twitch { get; set; }

        [JsonProperty("icon")]
        public int Icon { get; set; }

        [JsonProperty("ship")]
        public int Ship { get; set; }

        [JsonProperty("ball")]
        public int Ball { get; set; }

        [JsonProperty("ufo")]
        public int UFO { get; set; }

        [JsonProperty("wave")]
        public int Wave { get; set; }

        [JsonProperty("robot")]
        public int Robot { get; set; }

        [JsonProperty("spider")]
        public int Spider { get; set; }

        [JsonProperty("col1")]
        public int Colour1 { get; set; }

        [JsonProperty("col2")]
        public int Colour2 { get; set; }

        [JsonProperty("deathEffect")]
        public int DeathEffect { get; set; }

        [JsonProperty("glow")]
        public bool Glow { get; set; }
    }
}
