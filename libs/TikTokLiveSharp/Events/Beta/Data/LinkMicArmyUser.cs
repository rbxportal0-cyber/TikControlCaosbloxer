using TikTokLiveSharp.Events.Objects;

namespace TikTokLiveSharp.Events.Beta.Data
{
    public sealed class LinkMicArmyUser
    {
        public readonly long Id;
        public readonly long Data2; // Score?
        public readonly string UserName;
        public readonly Picture Avatar;

        private LinkMicArmyUser(Models.Protobuf.UnknownObjects.Data.LinkMicArmyUser armyUser)
        {
            Id = armyUser?.Id ?? -1;
            Data2 = armyUser?.Data2 ?? -1;
            UserName = armyUser?.UserName ?? string.Empty;
            Avatar = armyUser?.Avatar;
        }

        public static implicit operator LinkMicArmyUser(Models.Protobuf.UnknownObjects.Data.LinkMicArmyUser armyUser) => new LinkMicArmyUser(armyUser);
    }
}
