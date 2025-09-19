using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace CHARKOLE_Player
{
    public class PlayerInputController : MonoBehaviour
    {
        private PlayerMovement playerMovement;

        private void Awake()
        {
            playerMovement = GetComponent<PlayerMovement>();
        }

        public void HandleMoveInput(InputAction.CallbackContext context)
        {
            playerMovement.SetMovementDirection(context.ReadValue<Vector2>());
        }

        public void HandleLookInput(InputAction.CallbackContext context)
        {
            playerMovement.SetMouseLookPos(context.ReadValue<Vector2>());
        }

        public void HandleInteractInput(InputAction.CallbackContext context)
        {

        }

        public void HandleAttackInput(InputAction.CallbackContext context)
        {

        }

        public void HandleCrouchInput(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                playerMovement.StartCrouch();
            }
            else if (context.canceled)
            {
                playerMovement.EndCrouch();
            }
        }

        public void HandleJumpInput(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                playerMovement.StartJump();
            }
            else if (context.canceled)
            {
                playerMovement.EndJump();
            }
        }

        public void HandleSprintInput(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                playerMovement.StartSprint();
            }
            else if (context.canceled)
            {
                playerMovement.EndSprint();
            }
        }
    }
}