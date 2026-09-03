using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class LinkmicUserSettingInfo
    {
        public readonly long UserId;
        public readonly LinkmicUserSettingLayout Layout;
        public readonly int FixMicNum;
        public readonly int AllowRequestFromUser;
        public readonly int AllowRequestFromFollowerOnly;
        public readonly LinkmicApplierSortSetting ApplierSortSetting;

        private LinkmicUserSettingInfo(Models.Protobuf.Objects.LinkmicUserSettingInfo info)
        {
            UserId = info?.UserId ?? -1;
            Layout = info?.Layout ?? LinkmicUserSettingLayout.Linkmic_User_Setting_Layout_Grid;
            FixMicNum = info?.FixMicNum ?? 0;
            AllowRequestFromUser = info?.AllowRequestFromUser ?? 0;
            AllowRequestFromFollowerOnly = info?.AllowRequestFromFollowerOnly ?? 0;
            ApplierSortSetting = info?.ApplierSortSetting ?? LinkmicApplierSortSetting.Linkmic_Applier_Sort_Setting_None;
        }

        public static implicit operator LinkmicUserSettingInfo(Models.Protobuf.Objects.LinkmicUserSettingInfo info) => new LinkmicUserSettingInfo(info);
    }
}
