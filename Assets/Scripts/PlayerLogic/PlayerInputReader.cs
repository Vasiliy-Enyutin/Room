using UnityEngine;

namespace PlayerLogic
{
    public static class PlayerInputReader
    {
        public static Vector3 MoveDirection
        {
            get
            {
                return new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
            }
        }
    }
}
