namespace TikTokLiveSharp.Events.Objects
{
    public sealed class AttrUpdateResponseParams
    {
        private AttrUpdateResponseParams(Models.Protobuf.Objects.AttrUpdateResponseParams responseParams)
        { }

        public static implicit operator AttrUpdateResponseParams(Models.Protobuf.Objects.AttrUpdateResponseParams responseParams) => new AttrUpdateResponseParams(responseParams);
    }
}
