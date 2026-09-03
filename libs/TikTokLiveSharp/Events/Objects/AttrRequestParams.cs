namespace TikTokLiveSharp.Events.Objects
{
    public sealed class AttrRequestParams
    {
        public readonly string AttrTypes;

        private AttrRequestParams(Models.Protobuf.Objects.AttrRequestParams requestParams)
        {
            AttrTypes = requestParams?.AttrTypes ?? string.Empty;
        }

        public static implicit operator AttrRequestParams(Models.Protobuf.Objects.AttrRequestParams requestParams) => new AttrRequestParams(requestParams);
    }
}
