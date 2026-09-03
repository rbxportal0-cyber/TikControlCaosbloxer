namespace TikTokLiveSharp.Events
{
    public sealed class Speaker : AMessageData
    {
        internal Speaker(Models.Protobuf.Messages.SpeakerMessage msg)
            : base(msg?.Header)
        { }
    }
}