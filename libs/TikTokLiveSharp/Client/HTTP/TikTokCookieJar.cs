using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TikTokLiveSharp.Client.HTTP
{
    /// <summary>
    /// Holds Cookies for TikTok-Connection
    /// </summary>
    public class TikTokCookieJar : IEnumerable<string>
    {
        #region Properties
        /// <summary>
        /// Get the cookie by key
        /// </summary>
        /// <param name="key">The cookie key</param>
        /// <returns>Cookie value</returns>
        public string this[string key]
        {
            get => cookies[key];
            set => cookies[key] = value;
        }

        /// <summary>
        /// Number of Cookies in Jar
        /// </summary>
        public int Count => cookies?.Count ?? 0;

        /// <summary>
        /// Cookies in Jar
        /// </summary>
        public IDictionary<string, string> Cookies => cookies;

        /// <summary>
        /// Cookies in Jar
        /// </summary>
        private readonly IDictionary<string, string> cookies;
        #endregion

        #region Constructors
        /// <summary>
        /// Create a TikTok cookie jar instance.
        /// </summary>
        public TikTokCookieJar()
        {
            cookies = new Dictionary<string, string>();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Enumerates Cookies
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return cookies.GetEnumerator();
        }

        /// <summary>
        /// Enumerates Cookies
        /// </summary>
        public IEnumerator<string> GetEnumerator()
        {
            return cookies.Select(cookie => $"{cookie.Key}={cookie.Value};").GetEnumerator();
        }
        #endregion
    }
}
