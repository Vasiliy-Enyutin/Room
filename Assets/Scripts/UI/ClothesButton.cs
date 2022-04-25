using PlayerLogic;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class ClothesButton : MonoBehaviour
    {
        [SerializeField] private ClothesTypes _clothesType;

        private Button _button; 
            

        private void Awake()
        {
            _button = GetComponent<Button>();
        }

        private void OnEnable()
        {
            _button.onClick.AddListener(OnButtonPressed);
        }

        private void OnDisable()
        {
            _button.onClick.RemoveListener(OnButtonPressed);
        }

        private void OnButtonPressed()
        {
            ClothesButtonEventBroker.InvokeOnClothesButtonPressed(_clothesType);
        }
    }
}
