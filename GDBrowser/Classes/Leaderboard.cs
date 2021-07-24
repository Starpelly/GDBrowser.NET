using System.Collections.Generic;
using Newtonsoft.Json;

namespace GDBrowser.Models.Leaderboard
{
    public class Leaderboard
    {
        public int rank { get; set; }
        public string username { get; set; }
        public int playerID { get; set; }
        public int accountID { get; set; }
        public int stars { get; set; }
        public int demons { get; set; }
        public int cp { get; set; }
        public int coins { get; set; }
        public int usercoins { get; set; }
        public int diamonds { get; set; }
    }
}
