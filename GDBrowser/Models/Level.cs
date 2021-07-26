using System.Collections.Generic;
using Newtonsoft.Json;

namespace GDBrowser.Models.Level
{
    public class Level
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("playerID")]
        public int PlayerID { get; set; }

        [JsonProperty("accountID")]
        public int AccountID { get; set; }

        [JsonProperty("difficulty")]
        public string Difficulty { get; set; }

        [JsonProperty("downloads")]
        public int Downloads { get; set; }

        [JsonProperty("likes")]
        public int Likes { get; set; }

        [JsonProperty("disliked")]
        public bool Disliked { get; set; }

        [JsonProperty("length")]
        public string Length { get; set; }

        [JsonProperty("stars")]
        public int Stars { get; set; }

        [JsonProperty("orbs")]
        public int Orbs { get; set; }

        [JsonProperty("diamonds")]
        public int Diamonds { get; set; }

        [JsonProperty("featured")]
        public bool Featured { get; set; }

        [JsonProperty("epic")]
        public bool Epic { get; set; }

        [JsonProperty("gameVersion")]
        public string GameVersion { get; set; }

        [JsonProperty("editorTime")]
        public float EditorTime { get; set; }

        [JsonProperty("totalEditorTime")]
        public float TotalEditorTime { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("copiedID")]
        public int CopiedID { get; set; }

        [JsonProperty("twoPlayer")]
        public bool TwoPlayer { get; set; }

        [JsonProperty("officialSong")]
        public int OfficialSong { get; set; }

        [JsonProperty("customSong")]
        public int CustomSong { get; set; }

        [JsonProperty("coins")]
        public int Coins { get; set; }

        [JsonProperty("verifiedCoins")]
        public bool VerifiedCoins { get; set; }

        [JsonProperty("starsRequested")]
        public int StarsRequested { get; set; }

        [JsonProperty("ldm")]
        public bool LowDetailMode { get; set; }

        [JsonProperty("objects")]
        public int Objects { get; set; }

        [JsonProperty("large")]
        public bool Large { get; set; }

        [JsonProperty("cp")]
        public int CreatorPoints { get; set; }

        [JsonProperty("difficultyFace")]
        public string DifficultyFace { get; set; }

        [JsonProperty("songName")]
        public string SongName { get; set; }

        [JsonProperty("songAuthor")]
        public string SongAuthor { get; set; }

        [JsonProperty("songSize")]
        public string SongSize { get; set; }

        [JsonProperty("songID")]
        public int SongID { get; set; }

        [JsonProperty("songLink")]
        public string SongLink { get; set; }

        [JsonProperty("results")]
        public int Results { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }
    }
}
