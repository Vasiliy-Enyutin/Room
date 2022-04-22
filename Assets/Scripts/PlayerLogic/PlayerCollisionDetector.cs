using UnityEngine;

namespace PlayerLogic
{
    public class PlayerCollisionDetector : MonoBehaviour
    {        
        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out IOpenable openable))
            {
                openable.Open();
            }
            
            if (other.TryGetComponent(out Chest chest))
            {
                PlayerEventBroker.InvokeOnNextToChest();
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.TryGetComponent(out IOpenable openable))
            {
                openable.Close();
            }
            
            if (other.TryGetComponent(out Chest chest))
            {
                PlayerEventBroker.InvokeOnAwayFromChest();
            }
        }
    }
}
