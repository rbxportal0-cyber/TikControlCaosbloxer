namespace TikTokLiveSharp.Events.Objects
{
    public sealed class BattleUserSettings
    {
        public readonly bool IsTurnOn;
        public readonly bool AcceptNotFollowerInvite;
        public readonly bool AllowGiftToOtherHosts;

        private BattleUserSettings(Models.Protobuf.Objects.BattleUserSettings settings)
        {
            IsTurnOn = settings?.IsTurnOn ?? false;
            AcceptNotFollowerInvite = settings?.AcceptNotFollowerInvite ?? false;
            AllowGiftToOtherHosts = settings?.AllowGiftToOtherAnchors ?? false;
        }

        public static implicit operator BattleUserSettings(Models.Protobuf.Objects.BattleUserSettings settings) => new BattleUserSettings(settings);
    }
}
