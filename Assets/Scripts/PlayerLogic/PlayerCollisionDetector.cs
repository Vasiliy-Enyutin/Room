using FishNet.Object;
using UnityEngine;

namespace PlayerLogic
{
    public class PlayerCollisionDetector : NetworkBehaviour
    {        
        private void OnTriggerEnter(Collider other)
        {
            if (base.IsOwner == false)
                return;
            
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
            if (base.IsOwner == false)
                return;
            
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
