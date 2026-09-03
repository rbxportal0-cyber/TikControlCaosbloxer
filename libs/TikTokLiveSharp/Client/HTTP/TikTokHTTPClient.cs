using Newtonsoft.Json.Linq;
using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TikTokLiveSharp.Client.Config;
using TikTokLiveSharp.Client.Socket;
using TikTokLiveSharp.Errors.Connections;
using TikTokLiveSharp.Errors.Permissions;
using TikTokLiveSharp.Models.Protobuf.Messages;

namespace TikTokLiveSharp.Client.HTTP
{
    /// <summary>
    /// HTTP-Client for TikTok-WebPage & Signing-Page
    /// </summary>
    internal sealed class TikTokHttpClient
    {
        #region Properties
        /// <summary>
        /// TikTokLive-ClientName for Signing-Server
        /// </summary>
        private const string CLIENT_NAME = "ttlive-net";
        /// <summary>
        /// Number of Concurrent HTTP-Clients
        /// </summary>
        private static int concurrentClients = 0;
        /// <summary>
        /// Index for this Client
        /// </summary>
        private readonly int clientNum;
        /// <summary>
        /// Whether Compression is allowed for Responses
        /// </summary>
        private readonly bool compression;
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor for a HTTPClient
        /// </summary>
        /// <param name="timeout">Timeout for Connection</param>
        /// <param name="proxyHandler">Proxy for Connection</param>
        /// <param name="clientLanguage">Accepted Language for Client (ISO-format)</param>
        internal TikTokHttpClient(TimeSpan timeout, bool enableCompression = true, IWebProxy proxyHandler = null, string clientLanguage = null)
        {
            TikTokHttpRequest.Timeout = timeout;
            TikTokHttpRequest.WebProxy = proxyHandler;
            if (!string.IsNullOrEmpty(clientLanguage))
                TikTokHttpRequest.ClientLanguage = clientLanguage;
            compression = enableCompression;
            concurrentClients++;
            clientNum = concurrentClients;
        }

        /// <summary>
        /// Destructor for a HTTPClient
        /// </summary>
        ~TikTokHttpClient()
        {
            concurrentClients--;
        }
        #endregion

        #region Methods
        #region Internal
        /// <summary>
        /// Gets Response from WebCast-API
        /// </summary>
        /// <param name="path">Path to send Request to</param>
        /// <param name="parameters">Additional Parameters for Request</param>
        /// <param name="signUrl">Whether to sign URL using API</param>
        /// <returns>Task to Await. Result is Response from WebCast-API</returns>
        internal async Task<Response> GetDeserializedMessage(string path, IDictionary<string, object> parameters = null)
        {
            HttpContent get = await GetRequest(Constants.TIKTOK_URL_WEBCAST + path, parameters);
            return Serializer.Deserialize<Response>(await get.ReadAsStreamAsync());
        }

        /// <summary>
        /// Gets JSON-Object from WebCast-API
        /// </summary>
        /// <param name="path">Path to send Request to</param>
        /// <param name="parameters">Additional Parameters for Request</param>
        /// <param name="signUrl">Whether to sign URL using API</param>
        /// <returns>Task to Await. Result is JSON-Object</returns>
        internal async Task<JObject> GetJObjectFromWebcastApi(string path, IDictionary<string, object> parameters = null)
        {
            HttpContent get = await GetRequest(Constants.TIKTOK_URL_WEBCAST + path, parameters);
            return JObject.Parse(await get.ReadAsStringAsync());
        }

        /// <summary>
        /// Gets HTML for Live-Page
        /// </summary>
        /// <param name="uniqueId">ID for Host</param>
        /// <param name="signUrl">Whether to sign URL using API</param>
        /// <returns>Task to Await. Result is HTML for Live-Page</returns>
        internal async Task<string> GetLivestreamPage(string uniqueId, IDictionary<string, object> parameters = null)
        {
            HttpContent get = await GetRequest($"{Constants.TIKTOK_URL_WEB}@{uniqueId}/live/", parameters);
            return await get.ReadAsStringAsync();
        }

        /// <summary>
        /// Gets HTML for Live-Page
        /// </summary>
        /// <param name="uniqueId">ID for Host</param>
        /// <param name="signUrl">Whether to sign URL using API</param>
        /// <returns>Task to Await. Result is HTML for Profile-Page</returns>
        internal async Task<string> GetProfilePage(string uniqueId, IDictionary<string, object> parameters = null)
        {
            HttpContent get = await GetRequest($"{Constants.TIKTOK_URL_WEB}@{uniqueId}", parameters);
            return await get.ReadAsStringAsync();
        }

        internal async Task<TikTokWebSocketConnectionData> GetSignedWebsocketData(string roomId, string customServerUrl = null, string apiKey = null)
        {
            Dictionary<string, object> queries = new Dictionary<string, object>()
            {
                { "client", CLIENT_NAME },
                { "uuc", clientNum },
                { "room_id", roomId },
            };
            if (!string.IsNullOrEmpty(apiKey))
            {
                queries.Add("apiKey", apiKey);
            }
            ITikTokHttpRequest request = new TikTokHttpRequest(string.IsNullOrEmpty(customServerUrl) ? Constants.TIKTOK_SIGN_API : customServerUrl, false, false)
                .SetQueries(queries);
            HttpResponseMessage response = await request.GetResponse();
            if (response.StatusCode == HttpStatusCode.NotFound)
                throw new HttpRequestException("Request responded with 404 NOT_FOUND");
            if (!response.IsSuccessStatusCode)
            {
                if ((int)response.StatusCode == 429) // TooManyRequests
                {
                    if (response.Headers.TryGetValues("RateLimit-Reset", out IEnumerable<string> rateHeaders))
                    {
                        TimeSpan span = TimeSpan.FromSeconds(long.Parse(rateHeaders.First()));
                        throw new HttpRequestException($"[{(int)response.StatusCode}] Signing Rate Limit Reached. Try again in {span:mm\\:ss}.");
                    }
                    else
                    {
                        throw new HttpRequestException($"[{(int)response.StatusCode}] Signing Rate Limit Reached.");
                    }
                }
                else if ((int)response.StatusCode == 502) // Bad Gateway
                {
                    throw new HttpRequestException($"[{(int)response.StatusCode}] Signing Server not reachable.");
                }
                else if ((int)response.StatusCode == 503) // Unavailable
                {
                    throw new HttpRequestException($"[{(int)response.StatusCode}] Signing Server unavailable.");
                }
                else
                {
                    throw new HttpRequestException($"Signing request was unsuccessful [{(int)response.StatusCode}].");
                }
            }
            if (response.Headers.TryGetValues("x-set-tt-cookie", out IEnumerable<string> cookieHeaders))
            {
                try
                {
                    Response signingResponse = Serializer.Deserialize<Response>(await response.Content.ReadAsStreamAsync());
                    return new TikTokWebSocketConnectionData(roomId, cookieHeaders, signingResponse);
                }
                catch (Exception ex)
                {
                    throw new SignConnectionException("Could not parse response from Signing-Server.", ex);
                }                
            }
            else
            {
                throw new SignConnectionException("Signing-Server did not return required header(s).");
            }
        }

        /// <summary>
        /// Posts JSON-Object to WebCast-API
        /// </summary>
        /// <param name="path">Path to send to (sub-URL)</param>
        /// <param name="parameters">Additional Parameters for Request</param>
        /// <param name="json">Object to Post</param>
        /// <param name="signUrl">Whether to sign URL using API</param>
        /// <returns>Task to Await. Result is result of Post</returns>
        internal async Task<JObject> PostJObjectToWebcastApi(string path, IDictionary<string, object> parameters, JObject json)
        {
            HttpContent post = await PostRequest(Constants.TIKTOK_URL_WEBCAST + path, json.ToString(Newtonsoft.Json.Formatting.None), parameters);
            return JObject.Parse(await post.ReadAsStringAsync());
        }
        #endregion

        #region Private
        /// <summary>
        /// Creates HTTP-Request
        /// </summary>
        /// <param name="url">URL for Request</param>
        /// <param name="parameters">Additional Parameters for Request</param>
        /// <returns>HTTP-Request</returns>
        private static ITikTokHttpRequest BuildRequest(string url, bool enableCompression = true, IDictionary<string, object> parameters = null)
        {
            return new TikTokHttpRequest(url, enableCompression).SetQueries(parameters);
        }

        /// <summary>
        /// Sends HTTP-GetRequest to URL
        /// </summary>
        /// <param name="url">URL to send to</param>
        /// <param name="parameters">Additional Parameters for Request</param>
        /// <param name="signUrl">Whether to Sign URL using API</param>
        /// <returns>Task to await</returns>
        private async Task<HttpContent> GetRequest(string url, IDictionary<string, object> parameters = null)
        {
            ITikTokHttpRequest request = BuildRequest(url, compression, parameters);
            return await request.Get();
        }

        /// <summary>
        /// Sends HTTP-PostRequest to URL
        /// </summary>
        /// <param name="url">URL to send to</param>
        /// <param name="parameters">Additional Parameters for Request</param>
        /// <param name="signUrl">Whether to Sign URL using API</param>
        /// <returns>Task to await</returns>
        private async Task<HttpContent> PostRequest(string url, IDictionary<string, object> parameters = null)
        {
            ITikTokHttpRequest request = BuildRequest(url, compression, parameters);
            return await request.Post(null);
        }

        /// <summary>
        /// Sends HTTP-PostRequest to URL
        /// </summary>
        /// <param name="url">URL to send to</param>
        /// <param name="data">Data for Request</param>
        /// <param name="parameters">Additional Parameters for Request</param>
        /// <param name="signUrl">Whether to Sign URL using API</param>
        /// <returns>Task to await</returns>
        private async Task<HttpContent> PostRequest(string url, string data, IDictionary<string, object> parameters = null)
        {
            ITikTokHttpRequest request = BuildRequest(url, compression, parameters);
            return await request.Post(new StringContent(data, Encoding.UTF8));
        }
        #endregion
        #endregion
    }
}