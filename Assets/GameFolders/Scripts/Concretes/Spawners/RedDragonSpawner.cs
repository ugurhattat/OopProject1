using System.Collections;
using System.Collections.Generic;
using OopProject1.Abstracts.Spawners;
using OopProject1.Controllers;
using UnityEngine;

namespace OopProject1.Spawners
{
    public class RedDragonSpawner : BaseSpawner
    {
        [SerializeField] EnemyController enemy;

        protected override void Spawn()
        {
            Instantiate(enemy, this.transform);
        }
    }
}

