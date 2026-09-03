namespace TikTokLiveSharp.Events.Enums
{
    /// <summary>
    /// Translates Action in MemberMessage to readable Format
    /// </summary>
    [System.Serializable]
    public enum MemberMessageAction
    {
        Unknown = 0,
        Joined = 1,
        Subscribed = 3
        // ?? = 26
        // ?? = 27 (User2 is set to Host-Info?)
        // ?? = 50 (share?)
    }
}
