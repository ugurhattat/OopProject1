using System.Collections;
using System.Collections.Generic;
using OopProject1.Abstracts.Spawners;
using OopProject1.Controllers;
using Unity.Mathematics;
using UnityEngine;

namespace OopProject1.Spawners
{
    public class RedDragonSpawner : BaseSpawner
    {
        [SerializeField] private EnemyController enemy;

        protected override void Spawn()
        {
            Instantiate(enemy, this.transform);
        }
    }
}

