using TikTokLiveSharp.Events.Objects;

namespace TikTokLiveSharp.Events
{
    public sealed class RankText : AMessageData
    {
        public readonly int Scene;
        public readonly long OwnerIdxBeforeUpdate;
        public readonly long OwnerIdxAfterUpdate;
        public readonly Text SelfGetBadgeMsg;
        public readonly Text OtherGetBadgeMsg;
        public readonly long CurUserId;

        internal RankText(Models.Protobuf.Messages.RankTextMessage msg)
            : base(msg?.Header)
        {
            Scene = msg?.Scene ?? -1;
            OwnerIdxBeforeUpdate = msg?.OwnerIdxBeforeUpdate ?? -1;
            OwnerIdxAfterUpdate = msg?.OwnerIdxAfterUpdate ?? -1;
            SelfGetBadgeMsg = msg?.SelfGetBadgeMsg;
            OtherGetBadgeMsg = msg?.OtherGetBadgeMsg;
            CurUserId = msg?.CurUserId ?? -1;
        }
    }
}