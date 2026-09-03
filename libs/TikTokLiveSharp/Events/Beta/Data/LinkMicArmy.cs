using System.Collections.Generic;
using System.Linq;

namespace TikTokLiveSharp.Events.Beta.Data
{
    public sealed class LinkMicArmy
    {
        public readonly IReadOnlyList<LinkMicArmyUser> Users;
        public readonly uint Score;

        private LinkMicArmy(Models.Protobuf.UnknownObjects.Data.LinkMicArmy army)
        {
            Users = army?.Users?.Count > 0 ? army.Users.Select(u => (LinkMicArmyUser)u).ToList().AsReadOnly() : new List<LinkMicArmyUser>(0).AsReadOnly();
            Score = army?.Score ?? 0;
        }

        public static implicit operator LinkMicArmy(Models.Protobuf.UnknownObjects.Data.LinkMicArmy army) => new LinkMicArmy(army);
    }
}
