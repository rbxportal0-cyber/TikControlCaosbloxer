namespace TikTokLiveSharp.Events.Objects
{
    public sealed class AttrResponseParams
    {
        public readonly UserAttrResponse Data;

        private AttrResponseParams(Models.Protobuf.Objects.AttrResponseParams responseParams)
        {
            Data = responseParams?.Data;
        }

        public static implicit operator AttrResponseParams(Models.Protobuf.Objects.AttrResponseParams responseParams) => new AttrResponseParams(responseParams);
    }
}
