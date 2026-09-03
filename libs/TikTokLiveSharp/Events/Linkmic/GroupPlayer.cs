using ProtoBuf;
using System.Collections.Generic;
using System.Linq;
using TikTokLiveSharp.Models.Protobuf.LinkmicCommon.Enums;

namespace TikTokLiveSharp.Events.Linkmic
{
    public sealed class GroupPlayer
    {
        public readonly long ChannelId;
        public readonly Player User;

        private GroupPlayer(Models.Protobuf.LinkmicCommon.GroupPlayer player)
        {
            ChannelId = player?.ChannelId ?? -1;
            User = player?.User;
        }

        public static implicit operator GroupPlayer(Models.Protobuf.LinkmicCommon.GroupPlayer player) => new GroupPlayer(player);
    }
}
