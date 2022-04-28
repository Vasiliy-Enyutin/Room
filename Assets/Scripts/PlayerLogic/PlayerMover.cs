using FishNet.Object;
using UnityEngine;

namespace PlayerLogic
{
    [RequireComponent(typeof(CharacterController))]
    [RequireComponent(typeof(PlayerStats))]
    [RequireComponent(typeof(PlayerInputReader))]
    [RequireComponent(typeof(PlayerAnimationController))]
    public class PlayerMover : NetworkBehaviour
    {
        private CharacterController _characterController;
        private PlayerStats _playerStats;
        private PlayerAnimationController _playerAnimationController;
        private PlayerInputReader _inputReader;
        
        private Vector3 _movementDirection;


        private void Awake()
        {
            _characterController = GetComponent<CharacterController>();
            _playerStats = GetComponent<PlayerStats>();
            _playerAnimationController = GetComponent<PlayerAnimationController>();
            _inputReader = GetComponent<PlayerInputReader>();
        }

        private void Update()
        {
            if (!base.IsOwner)
                return;
            
            _movementDirection = _inputReader.MoveDirection;
            Move();
            UpdateAnimation();
        }

        private void Move()
        {
            if (_movementDirection.magnitude > 1)
                _movementDirection.Normalize();
            
            _characterController.Move(_movementDirection * _playerStats.MoveSpeed * Time.deltaTime);
            
            if (_movementDirection != Vector3.zero)
                transform.forward = _movementDirection;
        }

        private void UpdateAnimation()
        {
            _playerAnimationController.ChangeMoveAnimation(_movementDirection.x != 0 || _movementDirection.z != 0);
        }
    }
}
