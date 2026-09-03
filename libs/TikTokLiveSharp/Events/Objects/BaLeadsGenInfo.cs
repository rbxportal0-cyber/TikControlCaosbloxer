namespace TikTokLiveSharp.Events.Objects
{
    public sealed class BaLeadsGenInfo
    {
        public readonly bool LeadsGenPermission;
        public readonly string LeadsGenModel;

        private BaLeadsGenInfo(Models.Protobuf.Objects.BaLeadsGenInfo info)
        {
            LeadsGenPermission = info?.LeadsGenPermission ?? false;
            LeadsGenModel = info?.LeadsGenModel ?? string.Empty;
        }

        public static implicit operator BaLeadsGenInfo(Models.Protobuf.Objects.BaLeadsGenInfo info) => new BaLeadsGenInfo(info);
    }
}
