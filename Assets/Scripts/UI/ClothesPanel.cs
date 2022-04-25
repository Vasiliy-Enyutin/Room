using PlayerLogic;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class ClothesPanel : MonoBehaviour
    {
        [SerializeField] private Button[] _buttons;
    
    
        private void OnEnable()
        {
            PlayerEventBroker.OnNextToChest += ActivateButtons;
            PlayerEventBroker.OnAwayFromChest += DisableButtons;
        }

        private void OnDisable()
        {
            PlayerEventBroker.OnNextToChest -= ActivateButtons;
            PlayerEventBroker.OnAwayFromChest -= DisableButtons;
        }

        private void ActivateButtons()
        {
            ChangeButtonsInteractableState(true);
        }

        private void DisableButtons()
        {
            ChangeButtonsInteractableState(false);
        }

        private void ChangeButtonsInteractableState(bool interactableState)
        {
            foreach (Button button in _buttons)
            {
                button.interactable = interactableState;
            }
        }
    }
}
