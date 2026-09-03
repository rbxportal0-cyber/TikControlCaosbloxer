using TikTokLiveSharp.Events.Objects;

namespace TikTokLiveSharp.Events
{
    public sealed class SubCapsule : AMessageData
    {
        public readonly Text Description;
        public readonly Text BtnName;
        public readonly string BtnUrl;
        public readonly string CapsuleScene;
        public readonly long FromUserId;

        internal SubCapsule(Models.Protobuf.Messages.SubCapsuleMessage msg)
            : base(msg?.Header)
        {
            Description = msg?.Description;
            BtnName = msg?.BtnName;
            BtnUrl = msg?.BtnUrl ?? string.Empty;
            CapsuleScene = msg?.CapsuleScene ?? string.Empty;
            FromUserId = msg?.FromUserId ?? -1;
        }
    }
}