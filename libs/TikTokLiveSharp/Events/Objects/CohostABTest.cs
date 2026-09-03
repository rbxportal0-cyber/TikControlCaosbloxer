using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class CohostABTest
    {
        public readonly CohostABTestType ABTestType;
        public readonly long Group;

        private CohostABTest(Models.Protobuf.Objects.CohostABTest test)
        {
            ABTestType = test?.ABTestType ?? CohostABTestType.Cohost_AB_Test_Type_Unknown;
            Group = test?.Group ?? -1;
        }

        public static implicit operator CohostABTest(Models.Protobuf.Objects.CohostABTest test) => new CohostABTest(test);
    }
}
