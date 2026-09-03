namespace TikTokLiveSharp.Events.Data
{
    public sealed class BusinessContent
    {
        public enum Data
        {
            None = 0,
            MultiLiveContent = 100,
            CohostContent = 200
        }

        /// <summary>
        /// Describes which Data is set
        /// <para>
        /// All other values are NULL
        /// </para>
        /// </summary>
        public readonly Data DataType;

        public readonly long OverLength;
        
        // Only 1 of the types below will not be NULL
        // Which one this is can be checked by using <see cref="DataType"/>

        public readonly MultiLiveContent MultiLiveContent;
        public readonly CohostContent CohostContent;

        private BusinessContent(Models.Protobuf.Messages.BusinessContent businessContent)
        {
            DataType = businessContent?.BusinessData != null ? (Data)businessContent.BusinessData : Data.None;
            OverLength = businessContent?.OverLength ?? -1;
            MultiLiveContent = DataType == Data.MultiLiveContent ? businessContent?.MultiLiveContent : null;
            CohostContent = DataType == Data.CohostContent ? businessContent?.CohostContent : null;
        }

        public static implicit operator BusinessContent(Models.Protobuf.Messages.BusinessContent businessContent) => new BusinessContent(businessContent);
    }
}
