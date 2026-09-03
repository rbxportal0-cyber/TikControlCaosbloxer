namespace TikTokLiveSharp.Events.Data
{
    public sealed class MultiLiveContent
    {
        public enum Data
        {
            None = 0,
            ApplyBizContent = 1,
            InviteBizContent = 2,
            ReplyBizContent = 3,
            PermitBizContent = 4,
            JoinDirectBizContent = 5,
            KickOutBizContent = 6
        }

        /// <summary>
        /// Describes which Data is set
        /// <para>
        /// All other values are NULL
        /// </para>
        /// </summary>
        public readonly Data DataType;

        // Only 1 of the types below will not be NULL
        // Which one this is can be checked by using <see cref="DataType"/>

        public readonly ApplyBizContent ApplyBizContent;
        public readonly InviteBizContent InviteBizContent;
        public readonly ReplyBizContent ReplyBizContent;
        public readonly PermitBizContent PermitBizContent;
        public readonly JoinDirectBizContent JoinDirectBizContent;
        public readonly KickOutBizContent KickOutBizContent;

        private MultiLiveContent(Models.Protobuf.Messages.MultiLiveContent content)
        {
            DataType = content?.BusinessData != null ? (Data)content.BusinessData : Data.None;
            ApplyBizContent = DataType == Data.ApplyBizContent ? content?.ApplyBizContent : null;
            InviteBizContent = DataType == Data.InviteBizContent ? content?.InviteBizContent : null;
            ReplyBizContent = DataType == Data.ReplyBizContent ? content?.ReplyBizContent : null;
            PermitBizContent = DataType == Data.PermitBizContent ? content?.PermitBizContent : null;
            JoinDirectBizContent = DataType == Data.JoinDirectBizContent ? content?.JoinDirectBizContent : null;
            KickOutBizContent = DataType == Data.KickOutBizContent ? content?.KickOutBizContent : null;
        }

        public static implicit operator MultiLiveContent(Models.Protobuf.Messages.MultiLiveContent content) => new MultiLiveContent(content);
    }
}
