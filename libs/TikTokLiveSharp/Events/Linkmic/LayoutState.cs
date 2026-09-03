namespace TikTokLiveSharp.Events.Linkmic
{
    public sealed class LayoutState
    {
        public readonly string LayoutId;

        private LayoutState(Models.Protobuf.LinkmicCommon.LayoutState state)
        {
            LayoutId = state?.LayoutId ?? string.Empty;
        }

        public static implicit operator LayoutState(Models.Protobuf.LinkmicCommon.LayoutState state) => new LayoutState(state);
    }
}
