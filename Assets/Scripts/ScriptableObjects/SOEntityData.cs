using System;
using System.Collections.Generic;
using UnityEngine;

namespace CHARKOLE_Player
{
    [Serializable]
    public struct EntityData
    {
        public string name;
        public EntityType type;
        public GameObject prefab;
        public float moveSpeed;
        public float maxHealth;
        public float attackDamage;
    }

    [CreateAssetMenu(fileName = "SOEntityData", menuName = "Scriptable Objects/SOEntityData")]
    public class SOEntityData : ScriptableObject
    {
        [SerializeField]
        private List<EntityData> entities;

        public EntityData GetEntity(EntityType type)
        {
            foreach (EntityData entity in entities)
            {
                if (entity.type == type)
                {
                    return entity;
                }
            }
            return new EntityData();
        }
    }
}
