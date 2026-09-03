namespace TikTokLiveSharp.Events.Objects
{
    public sealed class LikeEffect
    {
        public readonly long Version;
        public readonly long EffectCount;
        public readonly long EffectIntervalMs;

        private LikeEffect(Models.Protobuf.Objects.LikeEffect effect)
        {
            Version = effect?.Version ?? -1;
            EffectCount = effect?.EffectCnt ?? -1;
            EffectIntervalMs = effect?.EffectIntervalMs ?? -1;
        }

        public static implicit operator LikeEffect(Models.Protobuf.Objects.LikeEffect effect) => new LikeEffect(effect);
    }
}
