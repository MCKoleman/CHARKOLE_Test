using System;
using UnityEngine;

namespace CHARKOLE_Player
{
    public class EntityMovement : MonoBehaviour
    {
        [SerializeField]
        protected Rigidbody rb;
        [SerializeField]
        protected Vector3 movementDir;
        [SerializeField]
        protected Vector2 lookDir;
        [SerializeField]
        protected bool isJumping;
        [SerializeField]
        protected bool isCrouching;
        [SerializeField]
        protected bool isSprinting;
        [SerializeField]
        protected float moveSpeed;

        private void FixedUpdate()
        {
            HandleMovement();
        }

        public virtual void Init(EntityData entityData)
        {
            this.moveSpeed = entityData.moveSpeed;

            // If the rigidbody was set manually, don't search for it
            if (rb != null) return;

            // Get rigidbody on this object
            rb = GetComponent<Rigidbody>();

            // If there is no rigidbody on this object, search children
            if (rb == null)
            {
                rb = GetComponentInChildren<Rigidbody>();
            }
        }

        public virtual Vector3 HandleMovement()
        {
            if (rb == null) return Vector3.zero;

            Vector3 movement = GetMovement();
            rb.linearVelocity = movement;
            return movement;
        }

        public void SetMovementDirection(Vector2 dir)
        {
            movementDir = new Vector3(dir.x, 0, dir.y);
        }

        public void SetLookDirection(Vector2 dir)
        {
            lookDir = dir;
        }

        public void StartCrouch()
        {
            isCrouching = true;
        }

        public void EndCrouch()
        {
            isCrouching = false;
        }

        public void StartJump()
        {
            isJumping = true;
        }

        public void EndJump()
        {
            isJumping = false;
        }

        public void StartSprint()
        {
            isSprinting = true;
        }

        public void EndSprint()
        {
            isSprinting = false;
        }

        private Vector3 GetMovement()
        {
            return this.transform.TransformDirection(movementDir * moveSpeed);
        }
    }
}