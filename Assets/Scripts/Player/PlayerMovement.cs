using System;
using UnityEngine;

namespace CHARKOLE_Player
{
    public class PlayerMovement : EntityMovement
    {
        [SerializeField]
        private Camera playerCamera;
        [SerializeField]
        private float lookSpeed;

        public override void Init(EntityData entityData)
        {
            base.Init(entityData);

            playerCamera = this.GetComponentInChildren<Camera>();
        }

        public override Vector3 HandleMovement()
        {
            Vector3 movement = base.HandleMovement();

            playerCamera.transform.position = rb.transform.position + movement;
            playerCamera.transform.rotation = Quaternion.Euler(lookDir.x, lookDir.y, 0);

            return movement;
        }

        public void SetMouseLookPos(Vector2 mousePos)
        {
            Vector2 newDir = new(Mathf.Clamp(lookDir.x - mousePos.y * lookSpeed, -89.9f, 89.9f), lookDir.y + mousePos.x * lookSpeed);
            this.SetLookDirection(newDir);
        }
    }
}