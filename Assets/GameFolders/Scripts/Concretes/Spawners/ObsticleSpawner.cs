using System.Collections;
using System.Collections.Generic;
using OopProject1.Abstracts.Spawners;
using OopProject1.Controllers;
using OopProject1.Movements;
using UnityEngine;

namespace OopProject1.Spawners
{
    public class ObstacleSpawner : BaseSpawner
    {
        [SerializeField] EnemyController[] enemies;

        protected override void Spawn()
        {
            //Range method 0'da kapsar ama altina gidemez ama 4 gelemez

            //                  1   2   3   4   5   6
            //                  0   1   2   3   4   5

            //int[] ornekler = { 10, 20, 30, 40, 50, 60 };

            //int[] ornek = new int[5];

            int enemyIndex = Random.Range(0, enemies.Length);
            Instantiate(enemies[enemyIndex], this.transform);
        }
    }
}


