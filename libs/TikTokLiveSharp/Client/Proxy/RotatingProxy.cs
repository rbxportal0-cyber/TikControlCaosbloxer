using System;
using System.Net;

namespace TikTokLiveSharp.Client.Proxy
{
    /// <summary>
    /// Proxy with list of rotating Addresses
    /// </summary>
    public class RotatingProxy : IWebProxy
    {
        #region Properties
        /// <summary>
        /// List of proxy-addresses
        /// </summary>
        public readonly string[] Addresses;

        /// <summary>
        /// Credentials for Proxies
        /// </summary>
        public ICredentials Credentials { get; set; }

        /// <summary>
        /// The number of available addresses.
        /// </summary>
        public int Count => Addresses.Length;

        /// <summary>
        /// The index of the current proxy-address.
        /// </summary>
        public int Index
        {
            get => index;
            set
            {
                if (value < 0 || value > Count - 1)
                    throw new IndexOutOfRangeException();
                index = value;
            }
        }

        /// <summary>
        /// Whether this Proxy is enabled
        /// </summary>
        public bool IsEnabled { get; set; }

        /// <summary>
        /// The rotation settings
        /// </summary>
        public RotationSettings Settings { get; set; }

        /// <summary>
        /// Current Index
        /// </summary>
        private int index;
        #endregion

        #region Constructors
        /// <summary>
        /// Creates an instance of proxy client factory.
        /// </summary>
        /// <param name="isEnabled">Are proxies enabled.</param>
        /// <param name="settings">The inital rotation settings to use.</param>
        /// <param name="addresses">The list of inital addresses.</param>
        public RotatingProxy(bool isEnabled = false,
            RotationSettings settings = RotationSettings.Consecutive,
            ICredentials credentials = null,
            params string[] addresses)
        {
            IsEnabled = isEnabled;
            Settings = settings;
            Credentials = credentials;
            Addresses = addresses;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Proxies for Url
        /// </summary>
        /// <param name="destination">Url to Proxy</param>
        /// <returns>Proxied Address</returns>
        public Uri GetProxy(Uri destination)
        {
            if (!IsEnabled || Addresses?.Length <= 0) 
                return destination;
            switch (Settings)
            {
                case RotationSettings.Consecutive:
                    string address = Addresses[Index];
                    Index = (Index + 1) % Count;
                    return new Uri(address);
                case RotationSettings.Random:
                    Index = new Random().Next(Count - 1);
                    return new Uri(Addresses[Index]);
                case RotationSettings.Pinned:
                    return new Uri(Addresses[Index]);
                default:
                    return destination;
            }
        }

        /// <summary>
        /// Whether this Proxy is Bypassed
        /// <para>
        /// Inverse of IsEnabled
        /// </para>
        /// </summary>
        /// <returns></returns>
        public bool IsBypassed(Uri host)
        {
            return !IsEnabled;
        }
        #endregion
    }
}