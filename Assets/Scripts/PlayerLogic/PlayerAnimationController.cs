using UnityEngine;

namespace PlayerLogic
{
    public class PlayerAnimationController : MonoBehaviour
    {
        private Animator _animator;
        private static readonly int _isMoving = Animator.StringToHash("IsMoving");


        private void Awake()
        {
            _animator = GetComponent<Animator>();
        }

        public void ChangeMoveAnimation(bool moveState)
        {
            _animator.SetBool(_isMoving, moveState);
        }
    }
}
