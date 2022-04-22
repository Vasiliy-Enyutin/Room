using System;

namespace PlayerLogic
{
    public static class PlayerEventBroker
    {
        public static event Action OnNextToChest;
        public static event Action OnAwayFromChest;

        public static void InvokeOnNextToChest()
        {
            OnNextToChest?.Invoke();
        }

        public static void InvokeOnAwayFromChest()
        {
            OnAwayFromChest?.Invoke();
        }
    }
}
