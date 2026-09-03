using System.Collections.Generic;
using System.Linq;
using TikTokLiveSharp.Events.Data;

namespace TikTokLiveSharp.Events
{
    public sealed class BoostCardMessage : AMessageData
    {
        public readonly IReadOnlyList<BoostCard> CardsList;

        internal BoostCardMessage(Models.Protobuf.Messages.BoostCardMessage msg)
            : base(msg?.Header)
        {
            CardsList = msg?.CardsList?.Count > 0 ? msg.CardsList.Select(c => (BoostCard)c).ToList().AsReadOnly() : new List<BoostCard>(0).AsReadOnly();
        }
    }
}