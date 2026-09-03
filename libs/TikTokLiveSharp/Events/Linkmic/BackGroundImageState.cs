namespace TikTokLiveSharp.Events.Linkmic
{
    public sealed class BackGroundImageState
    {
        public readonly string StickerId;

        private BackGroundImageState(Models.Protobuf.LinkmicCommon.BackGroundImageState state)
        {
            StickerId = state?.StickerId ?? string.Empty;
        }

        public static implicit operator BackGroundImageState(Models.Protobuf.LinkmicCommon.BackGroundImageState state) => new BackGroundImageState(state);
    }
}
