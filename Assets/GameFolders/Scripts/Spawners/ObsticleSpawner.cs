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

        //dizi array
        [SerializeField] EnemyController[] enemies;

        float _currentSpawnTime;
        float _timeBoundary;

        private void Start()
        {
            ResetTimes();
        }
        private void Update()
        {
            _currentSpawnTime += Time.deltaTime;

            if (_currentSpawnTime > _timeBoundary)
            {
                Spawn();
                ResetTimes();
            }
        }

        private void Spawn()
        {
            //Range method 0'da kapsar ama altina gidemez ama 4 gelemez
            int enemyIndex = Random.Range(0, 4);
            Instantiate(enemies[enemyIndex], this.transform);
        }

        private void ResetTimes()
        {
            _currentSpawnTime = 0f;
            _timeBoundary = Random.Range(minSpawnTime, maxSpawnTime);
        }
    }
}


