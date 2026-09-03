using System.Collections.Generic;

namespace TikTokLiveSharp.Events
{
    public sealed class ImDelete : AMessageData
    {
        public readonly IReadOnlyList<long> DeleteMessageIds;
        public readonly IReadOnlyList<long> DeleteUserIds;

        internal ImDelete(Models.Protobuf.Messages.ImDeleteMessage msg)
            : base(msg?.Header)
        {
            DeleteMessageIds = msg?.DeleteMsgIdsList?.Count > 0 ? new List<long>(msg.DeleteMsgIdsList).AsReadOnly() : new List<long>(0).AsReadOnly();
            DeleteUserIds = msg?.DeleteUserIdsList?.Count > 0 ? new List<long>(msg.DeleteUserIdsList).AsReadOnly() : new List<long>(0).AsReadOnly();
        }
    }
}