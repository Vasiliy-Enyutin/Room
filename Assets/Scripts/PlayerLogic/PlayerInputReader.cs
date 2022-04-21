using UnityEngine;

namespace PlayerLogic
{
    public class PlayerInputReader : MonoBehaviour
    {
        private Vector3 _moveDirection = Vector3.zero;

        public Vector3 MoveDirection => _moveDirection;


        private void Update()
        {
            _moveDirection = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        }
    }
}
