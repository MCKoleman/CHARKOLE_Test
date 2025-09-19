using System;
using System.Collections.Generic;
using UnityEngine;

namespace CHARKOLE_GameService
{
    public class ServiceInitializer : MonoBehaviour
    {
        [SerializeField]
        private List<GameService> services = new();

        public static ServiceInitializer Instance { get; private set; }

        private void Awake()
        {
            if (Instance != null)
            {
                Destroy(this.gameObject);
                return;
            }

            Instance = this;
            DontDestroyOnLoad(this.gameObject);

            RegisterServices();
        }

        protected void RegisterService<T>() where T : GameService
        {
            T service = this.GetComponentInChildren<T>();
            if (service == null)
            {
                Debug.LogError($"[ServiceInitializer]: Service {typeof(T)} does not exist on ServiceInitializer.");
                return;
            }
            ServiceLocator.Register<T>(service);
            service.Init();
        }

        protected virtual void RegisterServices()
        {
            foreach (GameService service in services)
            {
                ServiceLocator.Register(service);
                service.Init();
            }
        }
    }
}