using TikTokLiveSharp.Client;

namespace TikTokLiveSharp.Events
{
    /// <summary>
    /// Delegate for TikTok-Events
    /// </summary>
    /// <param name="sender">TikTokClient that threw the Event</param>
    /// <param name="e">Arguments for Event</param>
    public delegate void TikTokEventHandler(TikTokLiveClient sender, System.EventArgs e);

    /// <summary>
    /// Delegate for TikTok-Events
    /// </summary>
    /// <typeparam name="TEventArgs">Type for Event-Arguments <paramref name="e"/></typeparam>
    /// <param name="sender">TikTokClient that threw the Event</param>
    /// <param name="e">Arguments for Event</param>
    public delegate void TikTokEventHandler<TEventArgs>(TikTokLiveClient sender, TEventArgs e);
}
