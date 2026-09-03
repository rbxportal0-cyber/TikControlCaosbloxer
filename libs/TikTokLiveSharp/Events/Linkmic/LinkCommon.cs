using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace TikTokLiveSharp.Events.Linkmic
{
    public sealed class LinkCommon
    {
        public readonly int Scene;
        public readonly string Source;
        public readonly long AppId;
        public readonly long LiveId;
        public readonly IReadOnlyDictionary<string, string> Extra;

        private LinkCommon(Models.Protobuf.LinkmicCommon.LinkCommon linkCommon)
        {
            Scene = linkCommon?.Scene ?? -1;
            Source = linkCommon?.Source ?? string.Empty;
            AppId = linkCommon?.AppId ?? -1;
            LiveId = linkCommon?.LiveId ?? -1;
            Extra = linkCommon?.ExtraMap?.Count > 0 ? new ReadOnlyDictionary<string, string>(linkCommon.ExtraMap) : new ReadOnlyDictionary<string, string>(new Dictionary<string, string>(0));
        }

        public static implicit operator LinkCommon(Models.Protobuf.LinkmicCommon.LinkCommon linkCommon) => new LinkCommon(linkCommon);
    }
}
