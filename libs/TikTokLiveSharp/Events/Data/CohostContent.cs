namespace TikTokLiveSharp.Events.Data
{
    public sealed class CohostContent
    {
        public enum Data
        {
            None = 0,
            JoinGroupBizContent = 1,
            PermitJoinGroupBizContent = 2,
            ListChangeBizContent = 11
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
        public JoinGroupBizContent JoinGroupBizContent;
        public PermitJoinGroupBizContent PermitJoinGroupBizContent;
        public ListChangeBizContent ListChangeBizContent;

        private CohostContent(Models.Protobuf.Messages.CohostContent content)
        {
            DataType = content?.MsgContent != null ? (Data)content.MsgContent : Data.None;
            JoinGroupBizContent = DataType == Data.JoinGroupBizContent ? content?.JoinGroupBizContent : null;
            PermitJoinGroupBizContent = DataType == Data.PermitJoinGroupBizContent ? content?.PermitJoinGroupBizContent : null;
            ListChangeBizContent = DataType == Data.ListChangeBizContent ? content?.ListChangeBizContent : null;
        }

        public static implicit operator CohostContent(Models.Protobuf.Messages.CohostContent content) => new CohostContent(content);
    }
}
