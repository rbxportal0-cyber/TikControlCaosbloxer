namespace TikTokLiveSharp.Events.Objects
{
    public class TikTokGift
    {
        public delegate void TikTokGiftEventHandler<TEventArgs>(TikTokGift gift, TEventArgs args);
        public delegate void TikTokGiftChangedEventHandler(TikTokGift gift, long change, long newAmount);

        public event TikTokGiftChangedEventHandler OnAmountChanged;
        public event TikTokGiftEventHandler<long> OnStreakFinished;

        public readonly Gift Gift;

        public readonly User Sender;

        /// <summary>
        /// Usually NULL (if null, receiver is the Host)
        /// </summary>
        public readonly User Receiver;

        public long Amount { get; private set; }
        public bool StreakFinished { get; private set; }


        public TikTokGift(Models.Protobuf.Messages.GiftMessage message)
        {
            Gift = message?.Gift;
            Sender = message?.User;
            Amount = message?.ComboCount ?? 0;
            if (Gift.IsStreakable)
                StreakFinished = message?.RepeatEnd == 1;
            else
                StreakFinished = true;
            Receiver = message?.ToUser;
        }

        internal virtual void FinishStreak()
        {
#if UNITY // This Code is strictly for TikTokLive-Unity
            TikTokLiveUnity.Utils.Dispatcher.RunOnMainThread(() => {
#endif
                StreakFinished = true;
                OnStreakFinished?.Invoke(this, Amount);
#if UNITY
            });
#endif
        }

        internal void UpdateGiftAmount(long amount)
        {
#if UNITY // This Code is strictly for TikTokLive-Unity
            TikTokLiveUnity.Utils.Dispatcher.RunOnMainThread(() => {
#endif
                if (amount <= Amount)
                    return; // Streak-Message was received out-of-order. Streak is already higher than this.
                long change = amount - Amount;
                Amount = amount;
                OnAmountChanged?.Invoke(this, change, Amount);
#if UNITY
            });
#endif
        }
    }
}