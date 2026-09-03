using System.Collections.Generic;
using System.Linq;
using TikTokLiveSharp.Events.Linkmic;
using TikTokLiveSharp.Models.Protobuf.LinkmicCommon.Enums;

namespace TikTokLiveSharp.Events
{
    public sealed class LinkState : AMessageData
    {
        public readonly long ChannelId;
        public readonly Scene Scene;
        public readonly long Version;
        public readonly int NeedAck;
        public readonly LayoutState Layout;
        public readonly IReadOnlyList<LinkUserState> UserStates;
        public readonly long LinkStateClientSendTime;
        public readonly StateType StateType;
        public readonly BackGroundImageState Background;

        internal LinkState(Models.Protobuf.Messages.LinkStateMessage msg)
            : base(msg?.Header)
        {
            ChannelId = msg?.ChannelId ?? -1;
            Scene = msg?.Scene ?? Scene.Scene_Unknown;
            Version = msg?.Version ?? -1;
            NeedAck = msg?.NeedAck ?? -1;
            Layout = msg?.Layout;
            UserStates = msg?.UserStatesList?.Count > 0 ? msg.UserStatesList.Select(u => (LinkUserState)u).ToList().AsReadOnly() : new List<LinkUserState>(0).AsReadOnly();
            LinkStateClientSendTime = msg?.ClientSendTime ?? -1;
            StateType = msg?.StateType ?? StateType.State_Invalid;
            Background = msg?.Background;
        }
    }
}