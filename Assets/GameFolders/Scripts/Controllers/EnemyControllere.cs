using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace OopProject1.Controllers
{
    public class EnemyControllere : MonoBehaviour
    {
        [SerializeField] float maxLifeTime = 5f;

        float _currentTime;

        private void Update()
        {
            _currentTime += Time.deltaTime;

            if (_currentTime > maxLifeTime)
            {
                Destroy(this.gameObject);
            }
        }
    }
}

