using System;
using PlayerLogic;

namespace UI
{
    public static class ClothesButtonEventBroker
    {
        public static event Action<ClothesTypes> OnClothesButtonPressed;

        public static void InvokeOnClothesButtonPressed(ClothesTypes clothesType)
        {
            OnClothesButtonPressed?.Invoke(clothesType);
        }
    }
}
