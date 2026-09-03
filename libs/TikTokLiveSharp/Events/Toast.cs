namespace TikTokLiveSharp.Events
{
    public sealed class Toast : AMessageData
    {
        public readonly long DisplayDurationMillisecond;
        public readonly long DelayDisplayDurationMillisecond;

        internal Toast(Models.Protobuf.Messages.ToastMessage msg)
            : base(msg?.Header)
        {
            DisplayDurationMillisecond = msg?.DisplayDurationMillisecond ?? -1;
            DelayDisplayDurationMillisecond = msg?.DelayDisplayDurationMillisecond ?? -1;
        }
    }
}