using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace TikTokLiveSharp.Events.Linkmic
{
    public sealed class LinkBaseResp
    {
        public readonly long ErrCode;
        public readonly string ErrMsg;
        public readonly IReadOnlyDictionary<string, byte[]> Extra;

        private LinkBaseResp(Models.Protobuf.LinkmicCommon.LinkBaseResp linkBaseResp)
        {
            ErrCode = linkBaseResp?.ErrCode ?? -1;
            ErrMsg = linkBaseResp?.ErrMsg ?? string.Empty;
            Extra = linkBaseResp?.ExtraMap?.Count > 0 ? new ReadOnlyDictionary<string, byte[]>(linkBaseResp.ExtraMap) : new ReadOnlyDictionary<string, byte[]>(new Dictionary<string, byte[]>(0));
        }

        public static implicit operator LinkBaseResp(Models.Protobuf.LinkmicCommon.LinkBaseResp linkBaseResp) => new LinkBaseResp(linkBaseResp);
    }
}
