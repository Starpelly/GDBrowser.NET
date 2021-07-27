using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

using GDBrowser.Models.Profile;
using GDBrowser.Models.Level;
using GDBrowser.Models.Leaderboard;
using GDBrowser.Models.MapPacks;
using GDBrowser.Models.Gauntlets;

namespace GDBrowser
{
    /// <summary>
    /// GDBrowser Client
    /// </summary>
    public class GDBrowserClient
    {
        #region

        private readonly HttpClient _client = new HttpClient();

        #endregion

        #region Urls

        protected string ApiRootURL = "https://gdbrowser.com";

        #endregion

        #region Data URLs

        protected virtual string GetLevelURL(int id)
        {
            return $"{ApiRootURL}/api/level/{id}";
        }

        protected virtual string GetProfileURL(string username)
        {
            return $"{ApiRootURL}/api/profile/{username}";
        }

        // Dont try using this, its not done yet.
        protected virtual string GetSearchURL(int count, int[] diff, int demonFilter, int page, int gauntlet, int[] length, int songID)
        {
            string baseURL = $"{ApiRootURL}/api/search";
            string finalURL = baseURL;
            if (count > 0)
                finalURL += $"?count={count}";
            if (diff != null)
                finalURL += $"?count={diff}";
            if (demonFilter != 0)
                finalURL += $"&demonFilter={demonFilter}";

            return finalURL;
        }

        protected virtual string GetLeaderboardURL(bool creator, int count = 100)
        {
            string result;
            if (creator)
                result = $"{ApiRootURL}/api/leaderboard?creator";
            else
                 result = $"{ApiRootURL}/api/leaderboard";

            if (count != 100)
                 result += $"&count={count}";

            return result;
        }

        protected virtual string GetMapPacksURL()
        {
            return $"{ApiRootURL}/api/mappacks";
        }

        protected virtual string GetGauntletsURL()
        {
            return $"{ApiRootURL}/api/gauntlets";
        }

        protected virtual string GetAnalysisURL(int id)
        {
            return $"{ApiRootURL}/api/analyze/{id}";
        }

        protected virtual string GetSongVerifyURL(int id)
        {
            return $"{ApiRootURL}/api/song/{id}";
        }

        #endregion

        protected virtual async Task<TOutput> GetData<TOutput>(string rootURL)
        {
            try
            {
                var json = await _client.GetStringAsync(rootURL);
                return JsonConvert.DeserializeObject<TOutput>(json);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected virtual async Task<List<TOutput>> GetListData<TOutput>(string rootURL)
        {
            try
            {
                var json = await _client.GetStringAsync(rootURL);
                return JsonConvert.DeserializeObject<List<TOutput>>(json);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region Async Functions

        public virtual void SetAPIRootUrl(string url)
        {
            ApiRootURL = url;
        }

        /// <summary>
        /// Returns data about a level. 
        /// </summary>
        /// <param name="id">The level ID</param>
        public virtual Task<Level> GetLevelAsync(int id)
        {
            var url = GetLevelURL(id);
            return GetData<Level>(url);
        }

        /// <summary>
        /// Returns data about a profile / user.
        /// </summary>
        /// <param name="username">The username of the profile you want to request.</param>
        public virtual Task<Profile> GetProfileAsync(string username)
        {
            var url = GetProfileURL(username);
            Console.WriteLine(url);
            return GetData<Profile>(url);
        }

        public virtual Task<List<Level>> GetSearchAsync(int count, int[] diff, int demonFilter)
        {
            var url = GetSearchURL(count, diff, demonFilter, 0, 0, null, 0);
            return GetListData<Level>(url);
        }

        /// <summary>
        /// Returns data about the global leaderboard.
        /// </summary>
        /// <param name="creator">Creator Leaderboard?</param>
        /// <param name="count">How many profiles you want to show. (remember, arrays still start from 0, you will not imagine how stupid I looked trying to figure out why 249 returned the 250th profile)</param>
        public virtual Task<List<Leaderboard>> GetLeaderboardAsync(bool creator, int count = 100)
        {
            var url = GetLeaderboardURL(creator, count);
            return GetListData<Leaderboard>(url);
        }

        /// <summary>
        /// Returns an array with all the current map packs in the game. (No parameters)
        /// </summary>
        public virtual Task<List<MapPacks>> GetMapPacksAsync()
        {
            var url = GetMapPacksURL();
            return GetListData<MapPacks>(url);
        }

        /// <summary>
        /// Returns an array with all the current gauntlets in the game. (No parameters)
        /// </summary>
        public virtual Task<List<Gauntlets>> GetGauntletsAsync()
        {
            var url = GetGauntletsURL();
            return GetListData<Gauntlets>(url);
        }

        public virtual Task<GDBrowser.Models.Analysis.Analysis> GetLevelAnalysisAsync(int id)
        {
            var url = GetAnalysisURL(id);
            return GetData<GDBrowser.Models.Analysis.Analysis>(url);
        }

        /// <summary>
        /// Returns true or false whether or not the song is available for use. 
        /// </summary>
        /// <param name="id">The song ID (on Newgrounds)</param>
        public virtual Task<bool> GetSongVerificationAsync(int id)
        {
            var url = GetSongVerifyURL(id);
            return GetData<bool>(url);
        }

        #endregion
    }
}
