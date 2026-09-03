using System.Collections.Generic;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class LynxGiftExtra
    {
        public readonly long Id;
        public readonly long Code;
        public readonly long Type;
        public readonly IReadOnlyList<string> Params;
        public readonly string Extra;

        private LynxGiftExtra(Models.Protobuf.Objects.LynxGiftExtra extra)
        {
            Id = extra?.Id ?? -1;
            Code = extra?.Code ?? -1;
            Type = extra?.Type ?? -1;
            Params = extra?.ParamsList?.Count > 0 ? new List<string>(extra.ParamsList).AsReadOnly() : new List<string>(0).AsReadOnly();
            Extra = extra?.Extra ?? string.Empty;
        }

        public static implicit operator LynxGiftExtra(Models.Protobuf.Objects.LynxGiftExtra extra) => new LynxGiftExtra(extra);
    }
}
