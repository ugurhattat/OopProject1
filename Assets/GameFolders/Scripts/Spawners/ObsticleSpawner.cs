using System.Collections;
using System.Collections.Generic;
using OopProject1.Controllers;
using OopProject1.Movements;
using UnityEngine;

namespace OopProject1.Spawners
{
    public class ObstacleSpawner : MonoBehaviour
    {
        [Range(2f,5f)]
        [SerializeField] float maxSpawnTime = 3f;
        [Range(0.3f,1.5f)]
        [SerializeField] float minSpawnTime = 1f;

        [SerializeField] EnemyController enemy;

        float _currentSpawnTime;
        float _timeBoundary;

        private void Awake()
        {
            _timeBoundary = Random.Range(minSpawnTime, maxSpawnTime);
        }
        private void Update()
        {
            _currentSpawnTime += Time.deltaTime;

            if (_currentSpawnTime > _timeBoundary)
            {
                Spawn();
                _currentSpawnTime = 0f;
            }
        }

        private void Spawn()
        {
            Instantiate(enemy, transform.position, transform.rotation);
        }
    }
}


