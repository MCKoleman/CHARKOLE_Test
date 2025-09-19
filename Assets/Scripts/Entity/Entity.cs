using System;
using UnityEngine;

namespace CHARKOLE_Player
{
    public class Entity : MonoBehaviour
    {
        [SerializeField]
        protected EntityHealth health;
        [SerializeField]
        protected EntityMovement movement;
        [SerializeField]
        protected EntityType type;
        [SerializeField]
        protected EntityData data;

        private void Start()
        {
            health = this.GetComponent<EntityHealth>();
            movement = this.GetComponent<EntityMovement>();
            data = GameServices.DataManager.GetEntityData(type);

            if (health != null)
            {
                health.Init(data);
            }

            if (movement != null)
            {
                movement.Init(data);
            }
        }
    }
}