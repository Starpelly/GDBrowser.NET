using System.Collections.Generic;
using Newtonsoft.Json;


namespace GDBrowser.Models.Analysis
{
    public class Analysis
    {
        [JsonProperty("level")]
        public Level Level { get; set; }

        [JsonProperty("objects")]
        public int Objects { get; set; }

        [JsonProperty("highDetail")]
        public int HighDetail { get; set; }

        [JsonProperty("settings")]
        public Settings Settings { get; set; }

        [JsonProperty("portals")]
        public string Portals { get; set; }

        [JsonProperty("coins")]
        public List<int> Coins { get; set; }

        [JsonProperty("coinsVerified")]
        public bool CoinsVerified { get; set; }

        [JsonProperty("orbs")]
        public Orbs Orbs { get; set; }

        [JsonProperty("triggers")]
        public Triggers Triggers { get; set; }

        [JsonProperty("triggerGroups")]
        public TriggerGroups TriggerGroups { get; set; }

        [JsonProperty("blocks")]
        public Blocks Blocks { get; set; }

        [JsonProperty("misc")]
        public Misc Misc { get; set; }

        [JsonProperty("colors")]
        public List<Color> Colors { get; set; }

        [JsonProperty("text")]
        public List<List<string>> Text { get; set; }

        [JsonProperty("dataLength")]
        public int DataLength { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }
    }

    public class Level
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("playerID")]
        public string PlayerID { get; set; }

        [JsonProperty("accountID")]
        public string AccountID { get; set; }

        [JsonProperty("large")]
        public bool Large { get; set; }
    }

    public class Settings
    {
        [JsonProperty("songOffset")]
        public int SongOffset { get; set; }

        [JsonProperty("fadeIn")]
        public bool FadeIn { get; set; }

        [JsonProperty("fadeOut")]
        public bool FadeOut { get; set; }

        [JsonProperty("background")]
        public int Background { get; set; }

        [JsonProperty("ground")]
        public int Ground { get; set; }

        [JsonProperty("alternateLine")]
        public bool AlternateLine { get; set; }

        [JsonProperty("font")]
        public int Font { get; set; }

        [JsonProperty("gamemode")]
        public string GameMode { get; set; }

        [JsonProperty("startMini")]
        public bool StartMini { get; set; }

        [JsonProperty("startDual")]
        public bool StartDual { get; set; }

        [JsonProperty("speed")]
        public string Speed { get; set; }

        [JsonProperty("twoPlayer")]
        public bool TwoPlayer { get; set; }
    }

    public class Orbs
    {
        [JsonProperty("yellow")]
        public int Yellow { get; set; }

        [JsonProperty("blue")]
        public int Blue { get; set; }

        [JsonProperty("pink")]
        public int Pink { get; set; }

        [JsonProperty("green")]
        public int Green { get; set; }

        [JsonProperty("black")]
        public int Black { get; set; }

        [JsonProperty("red")]
        public int Red { get; set; }

        [JsonProperty("trigger")]
        public int Trigger { get; set; }

        [JsonProperty("greenDash")]
        public int GreenDash { get; set; }

        [JsonProperty("pinkDash")]
        public int PinkDash { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class Triggers
    {
        public int Transition { get; set; }
        public int Color { get; set; }
        public int StartPos2 { get; set; }
        public int EnableTrail { get; set; }
        public int DisableTrail { get; set; }
        public int Move { get; set; }
        public int Pulse { get; set; }
        public int Alpha { get; set; }
        public int Toggle { get; set; }
        public int Spawn { get; set; }
        public int Rotate { get; set; }
        public int Follow { get; set; }
        public int Shake { get; set; }
        public int Animate { get; set; }
        public int Touch { get; set; }
        public int Count { get; set; }
        public int HidePlayer { get; set; }
        public int ShowPlayer { get; set; }
        public int Stop { get; set; }
        public int InstantCount { get; set; }
        public int OnDeath { get; set; }
        public int FollowPlayerY { get; set; }
        public int Collision { get; set; }
        public int Pickup { get; set; }
        public int BGEffectOn { get; set; }
        public int BGEffectOff { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class TriggerGroups
    {
        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class Blocks
    {
        [JsonProperty("rock")]
        public int Rock { get; set; }

        [JsonProperty("crystal")]
        public int Crystal { get; set; }

        [JsonProperty("the-confusing-one")]
        public int TheConfusingOne { get; set; }
        [JsonProperty("outline")]
        public int Outline { get; set; }

        [JsonProperty("grass-color")]
        public int GrassColor { get; set; }
        [JsonProperty("grass")]
        public int Grass { get; set; }
        [JsonProperty("edge")]
        public int Edge { get; set; }
        [JsonProperty("rainbow")]
        public int Rainbow { get; set; }
        [JsonProperty("brick2")]
        public int Brick2 { get; set; }

        [JsonProperty("mech-color")]
        public int MechColor { get; set; }
        [JsonProperty("pattern")]
        public int Pattern { get; set; }
        [JsonProperty("electric3")]
        public int Electric3 { get; set; } // I don't even know what the fuck this means lol
        [JsonProperty("glass")]
        public int Glass { get; set; }
        [JsonProperty("mech")]
        public int Mech { get; set; }

        [JsonProperty("mech-dark")]
        public int MechDark { get; set; }
        [JsonProperty("puzzle")]
        public int Puzzle { get; set; }
        [JsonProperty("squares")]
        public int Squares { get; set; }
        [JsonProperty("triangles")]
        public int Triangles { get; set; }
        [JsonProperty("black")]
        public int Black { get; set; }
        [JsonProperty("brick")]
        public int Brick { get; set; }
        [JsonProperty("electro")]
        public int Electro { get; set; }
        [JsonProperty("wavy")]
        public int Wavy { get; set; }
        [JsonProperty("chipped")]
        public int Chipped { get; set; }

        [JsonProperty("squares-color")]
        public int SquaresColor { get; set; }

        [JsonProperty("wavy-color")]
        public int WavyColor { get; set; }
        [JsonProperty("color")]
        public int Color { get; set; }

        [JsonProperty("triangles-color")]
        public int TrianglesColor { get; set; }

        [JsonProperty("brick-color")]
        public int BrickColor { get; set; }

        [JsonProperty("chipped-color")]
        public int ChippedColor { get; set; }
        [JsonProperty("electric")]
        public int Electric { get; set; }
        [JsonProperty("electric2")]
        public int Electric2 { get; set; }
        [JsonProperty("rock2")]
        public int Rock2 { get; set; }
        [JsonProperty("brick3")]
        public int Brick3 { get; set; }
        [JsonProperty("cracked")]
        public int Cracked { get; set; }
        [JsonProperty("moon")]
        public int Moon { get; set; }
        [JsonProperty("wood")]
        public int Wood { get; set; }
        [JsonProperty("cracked2")]
        public int Cracked2 { get; set; }
        [JsonProperty("classic")]
        public int Classic { get; set; }
    }

    public class Misc
    {
        [JsonProperty("texts")]
        public List<object> Texts { get; set; }

        [JsonProperty("glows")]
        public List<object> Glows { get; set; }

        [JsonProperty("saws")]
        public List<object> Saws { get; set; }

        [JsonProperty("pulses")]
        public List<object> Pulses { get; set; }

        [JsonProperty("invisibles")]
        public List<object> Invisibles { get; set; }

        [JsonProperty("spikes")]
        public List<object> Spikes { get; set; }

        [JsonProperty("arrows")]
        public List<object> Arrows { get; set; }

        [JsonProperty("clouds")]
        public List<object> Clouds { get; set; }

        [JsonProperty("monsters")]
        public List<object> Monsters { get; set; }

        [JsonProperty("fires")]
        public List<object> Fires { get; set; }

        [JsonProperty("pickups")]
        public List<object> Pickups { get; set; }

        [JsonProperty("particles")]
        public List<object> Particles { get; set; }

        [JsonProperty("hands")]
        public List<object> Hands { get; set; }

        [JsonProperty("pixels")]
        public List<object> Pixels { get; set; }

        [JsonProperty("breakables")]
        public List<object> Breakables { get; set; }

        [JsonProperty("collisions")]
        public List<object> Collisions { get; set; }
    }

    public class Color
    {
        [JsonProperty("r")]
        public string R { get; set; }
        [JsonProperty("g")]
        public string G { get; set; }
        [JsonProperty("b")]
        public string B { get; set; }

        [JsonProperty("channel")]
        public string Channel { get; set; }

        [JsonProperty("opacity")]
        public int Opacity { get; set; }

        [JsonProperty("blending")]
        public bool? Blending { get; set; }
    }
}
