using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OopProject1.Combats
{
    public class Dead : MonoBehaviour
    {
        [SerializeField] bool _isDead;
        public bool IsDead => _isDead;

        public event System.Action OnDead;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            _isDead = true;
            OnDead?.Invoke();
            Time.timeScale = 0f;
        }
    }
}

