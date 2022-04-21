using UnityEngine;

namespace PlayerLogic
{
    [RequireComponent(typeof(CharacterController))]
    public class PlayerGravityModifier : MonoBehaviour
    {
        private readonly Vector3 _gravity = Physics.gravity;
        private CharacterController _characterController;


        private void Awake()
        {
            _characterController = GetComponent<CharacterController>();
        }

        private void Update()
        {
            if (CheckForGrounded() == true)
                return;
            
            ApplyGravity();
        }

        private bool CheckForGrounded()
        {
            return _characterController.isGrounded;
        }

        private void ApplyGravity()
        {
            _characterController.Move(_gravity * Time.deltaTime);
        }
    }
}
