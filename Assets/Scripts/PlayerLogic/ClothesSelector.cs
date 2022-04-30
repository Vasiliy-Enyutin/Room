using FishNet.Object;
using UI;
using UnityEngine;

namespace PlayerLogic
{
    public class ClothesSelector : NetworkBehaviour
    {
        [SerializeField] private ClothesTypes _clothesType;
        [SerializeField] private GameObject[] _clothes;
        [SerializeField] private int _currentClothesArrayIndex;


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
            if (base.IsOwner == false || clothesType != _clothesType)
                return;
            
            ChangeClothes(ref _currentClothesArrayIndex);
        }

        private void ChangeClothes(ref int currentIndex)
        {
            _clothes[currentIndex].SetActive(false);
            currentIndex = ++currentIndex % _clothes.Length;
            _clothes[currentIndex].SetActive(true);
        }
    }
}
