using System;
using UnityEngine;
using CHARKOLE_GameService;

namespace CHARKOLE_Player
{
    public class DataManager : GameService
    {
        [SerializeField]
        private SOEntityData entityData;

        public EntityData GetEntityData(EntityType type)
        {
            return entityData.GetEntity(type);
        }
    }
}