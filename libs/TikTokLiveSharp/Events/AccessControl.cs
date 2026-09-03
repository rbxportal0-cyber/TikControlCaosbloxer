namespace TikTokLiveSharp.Events
{
    public sealed class AccessControl : AMessageData
    {
        public readonly bool IsSet;
        public readonly long CaptchaRecordId;
        public readonly long AccessControlRoomId;
        public readonly long VerifyDurationInSec;

        internal AccessControl(Models.Protobuf.Messages.AccessControlMessage msg)
            : base(msg?.Header)
        {
            if (msg?.MsgContent == Models.Protobuf.Messages.AccessControlMessage.MsgContentCase.Captcha)
            {
                IsSet = true;
                Models.Protobuf.Messages.AccessControlCaptcha captcha = msg.Captcha;
                CaptchaRecordId = captcha.CaptchaRecordId;
                AccessControlRoomId = captcha.RoomId;
                VerifyDurationInSec = captcha.VerifyDurationInSec;
            }
            else
            {
                IsSet = false;
                CaptchaRecordId = -1;
                AccessControlRoomId = -1;
                VerifyDurationInSec = -1;
            }
        }
    }
}