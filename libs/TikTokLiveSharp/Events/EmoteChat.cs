using System.Collections.Generic;
using System.Linq;
using TikTokLiveSharp.Events.Objects;

namespace TikTokLiveSharp.Events
{
    public sealed class EmoteChat : AMessageData
    {
        public readonly User User;
        public readonly IReadOnlyList<Emote> Emotes;
        public readonly MsgFilter MsgFilter;
        public readonly UserIdentity UserIdentity;

        internal EmoteChat(Models.Protobuf.Messages.EmoteChatMessage msg)
            : base(msg?.Header)
        {
            User = msg?.User;
            Emotes = msg?.EmoteList?.Count > 0 ? msg.EmoteList.Select(e => (Emote)e).ToList().AsReadOnly() : new List<Emote>(0).AsReadOnly();
            MsgFilter = msg?.MsgFilter;
            UserIdentity = msg?.UserIdentity;
        }
    }
}