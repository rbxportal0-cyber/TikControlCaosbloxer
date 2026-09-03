using System.Collections.Generic;
using System.Linq;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class CohostABTestList
    {
        public readonly IReadOnlyList<CohostABTest> ABTestList;

        private CohostABTestList(Models.Protobuf.Objects.CohostABTestList testList)
        {
            ABTestList = testList?.ABTestList?.Count > 0 ? testList.ABTestList.Select(t => (CohostABTest)t).ToList().AsReadOnly() : new List<CohostABTest>(0).AsReadOnly();
        }

        public static implicit operator CohostABTestList(Models.Protobuf.Objects.CohostABTestList testList) => new CohostABTestList(testList);
    }
}
