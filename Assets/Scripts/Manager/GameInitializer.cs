using System;
using UnityEngine;
using CHARKOLE_GameService;

namespace CHARKOLE_Player
{
    public class GameInitializer : ServiceInitializer
    {
        protected override void RegisterServices()
        {
            base.RegisterServices();
            RegisterService<GameManager>();
            RegisterService<DataManager>();
            RegisterService<InputManager>();
            RegisterService<PlayerManager>();
        }
    }
}