using System.Collections.Generic;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class GiftIMPriority
    {
        public readonly IReadOnlyList<long> QueueSizes;
        public readonly long SelfQueuePriority;
        public readonly long Priority;

        private GiftIMPriority(Models.Protobuf.Objects.GiftIMPriority imPriority)
        {
            QueueSizes = imPriority?.QueueSizesList?.Count > 0 ? new List<long>(imPriority.QueueSizesList).AsReadOnly() : new List<long>(0).AsReadOnly();
            SelfQueuePriority = imPriority?.SelfQueuePriority ?? -1;
            Priority = imPriority?.Priority ?? -1;
        }

        public static implicit operator GiftIMPriority(Models.Protobuf.Objects.GiftIMPriority imPriority) => new GiftIMPriority(imPriority);
    }
}
