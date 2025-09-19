using System;
using UnityEngine;
using CHARKOLE_GameService;

namespace CHARKOLE_Player
{
    public static class GameServices
    {
        public static GameManager GameManager = ServiceLocator.Get<GameManager>();
        public static PlayerManager PlayerManager = ServiceLocator.Get<PlayerManager>();
        public static InputManager InputManager = ServiceLocator.Get<InputManager>();
        public static DataManager DataManager = ServiceLocator.Get<DataManager>();
    }
}