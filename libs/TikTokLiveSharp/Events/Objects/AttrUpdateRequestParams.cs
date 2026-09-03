namespace TikTokLiveSharp.Events.Objects
{
    public sealed class AttrUpdateRequestParams
    {
        public readonly long AttrType;
        public readonly long Value;

        private AttrUpdateRequestParams(Models.Protobuf.Objects.AttrUpdateRequestParams requestParams)
        {
            AttrType = requestParams?.AttrType ?? -1;
            Value = requestParams?.Value ?? -1;
        }

        public static implicit operator AttrUpdateRequestParams(Models.Protobuf.Objects.AttrUpdateRequestParams requestParams) => new AttrUpdateRequestParams(requestParams);
    }
}
