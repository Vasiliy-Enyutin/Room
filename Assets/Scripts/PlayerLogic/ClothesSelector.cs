using FishNet.Object;
using UI;
using UnityEngine;

namespace PlayerLogic
{
    public class ClothesSelector : NetworkBehaviour
    {
        [SerializeField] private GameObject[] _bodies;
        [SerializeField] private GameObject[] _pants;
        [SerializeField] private GameObject[] _boots;

        [SerializeField] private int _currentBodyArrayIndex;
        [SerializeField] private int _currentPantsArrayIndex;
        [SerializeField] private int _currentBootsArrayIndex;


        private void OnEnable()
        {
            ClothesButtonEventBroker.OnClothesButtonPressed += SelectClothesType;
        }

        private void OnDisable()
        {
            ClothesButtonEventBroker.OnClothesButtonPressed -= SelectClothesType;
        }

        private void SelectClothesType(ClothesTypes clothesType)
        {
            if (base.IsOwner == false)
                return;
            
            if (clothesType == ClothesTypes.Body)
                ChangeClothes(_bodies, ref _currentBodyArrayIndex);
            else if (clothesType == ClothesTypes.Pants)
                ChangeClothes(_pants, ref _currentPantsArrayIndex);
            else if (clothesType == ClothesTypes.Boots)
                ChangeClothes(_boots, ref _currentBootsArrayIndex);
        }

        private void ChangeClothes(GameObject[] clothes, ref int currentIndex)
        {
            clothes[currentIndex].SetActive(false);
            currentIndex = ++currentIndex % clothes.Length;
            clothes[currentIndex].SetActive(true);
        }
    }
}
