using UnityEngine;

namespace PlayerLogic
{
    [RequireComponent(typeof(CharacterController))]
    [RequireComponent(typeof(PlayerStats))]
    public class PlayerMover : MonoBehaviour
    {
        private CharacterController _characterController;
        private PlayerStats _playerStats;

        private PlayerInputReader _inputReader;


        private void Awake()
        {
            _characterController = GetComponent<CharacterController>();
            _playerStats = GetComponent<PlayerStats>();
            _inputReader = GetComponent<PlayerInputReader>();
        }

        private void Update()
        {
            Move();
        }

        private void Move()
        {
            Vector3 _movementDirection = _inputReader.MoveDirection;
            
            if (_movementDirection.magnitude > 1)
                _movementDirection.Normalize();
            
            _characterController.Move(_movementDirection * _playerStats.MoveSpeed * Time.deltaTime);
            
            if (_movementDirection != Vector3.zero)
                transform.forward = _movementDirection;
        }
    }
}
