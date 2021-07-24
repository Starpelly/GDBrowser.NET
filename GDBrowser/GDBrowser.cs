using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

using GDBrowser.Models.Profile;
using GDBrowser.Models.Level;

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

        protected virtual string ApiRootURL => "https://gdbrowser.com";

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

        #region Async Functions

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
            return GetData<Profile>(url);
        }

        #endregion
    }
}
