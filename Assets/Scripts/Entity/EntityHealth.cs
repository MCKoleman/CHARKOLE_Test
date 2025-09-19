using System;
using UnityEngine;

namespace CHARKOLE_Player
{
    public class EntityHealth : MonoBehaviour
    {
        [SerializeField]
        private float curHealth;
        [SerializeField]
        private float maxHealth;
        [SerializeField]
        private bool isDead;

        public delegate void DeathEvent();
        public static event DeathEvent OnDeath;

        public float Health
        {
            get { return curHealth; }
            private set { curHealth = Mathf.Clamp(value, 0.0f, maxHealth); }
        }

        public float MaxHealth
        {
            get { return maxHealth; }
            private set { maxHealth = value; }
        }

        public float HealthPercent
        {
            get { return Health / Mathf.Max(MaxHealth, 1.0f); }
        }

        public bool IsDead
        {
            get { return isDead; }
            private set { isDead = value; }
        }

        public void Init(EntityData entityData)
        {
            MaxHealth = entityData.maxHealth;
            HandleReset();
        }

        public float TakeDamage(float amount)
        {
            Health -= amount;
            if (Health <= 0.0f && !isDead)
            {
                HandleDeath();
            }
            return Health;
        }

        public float Heal(float amount)
        {
            Health += amount;
            return Health;
        }

        public float SetHealth(float amount)
        {
            Health = amount;
            return Health;
        }

        public void HandleReset()
        {
            Health = MaxHealth;
            IsDead = false;
        }

        protected virtual void HandleDeath()
        {
            IsDead = true;
            OnDeath?.Invoke();
        }
    }
}