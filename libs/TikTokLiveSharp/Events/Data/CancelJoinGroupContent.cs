using System.Collections.Generic;
using System.Linq;
using TikTokLiveSharp.Events.Linkmic;
using TikTokLiveSharp.Models.Protobuf.Messages.Enums;

namespace TikTokLiveSharp.Events.Data
{
    public sealed class CancelJoinGroupContent
    {
        public readonly IReadOnlyList<GroupPlayer> LeaverList;
        public readonly GroupPlayer Operator;
        public readonly ListChangeType Type;

        private CancelJoinGroupContent(Models.Protobuf.Messages.CancelJoinGroupContent content)
        {
            LeaverList = content?.LeaverList?.Count > 0 ? content.LeaverList.Select(p => (GroupPlayer)p).ToList().AsReadOnly() : new List<GroupPlayer>(0).AsReadOnly();
            Operator = content?.Operator;
            Type = content?.Type ?? ListChangeType.List_Leave;
        }

        public static implicit operator CancelJoinGroupContent(Models.Protobuf.Messages.CancelJoinGroupContent content) => new CancelJoinGroupContent(content);
    }
}
