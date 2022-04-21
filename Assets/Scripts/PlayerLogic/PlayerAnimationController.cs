using UnityEngine;

namespace PlayerLogic
{
    public class PlayerAnimationController : MonoBehaviour
    {
        private PlayerInputReader _inputReader;
        
        private Animator _animator;
        private static readonly int _isMoving = Animator.StringToHash("IsMoving");


        private void Awake()
        {
            _inputReader = GetComponent<PlayerInputReader>();
            _animator = GetComponent<Animator>();
        }

        private void Update()
        {
            UpdateAnimation();
        }

        private void UpdateAnimation()
        {
            _animator.SetBool(_isMoving, _inputReader.MoveDirection.magnitude > Mathf.Epsilon);
        }
    }
}
