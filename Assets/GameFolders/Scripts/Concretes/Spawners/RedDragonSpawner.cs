using System.Collections;
using System.Collections.Generic;
using OopProject1.Abstracts.Spawners;
using OopProject1.Controllers;
using OopProject1.Pools;
using Unity.Mathematics;
using UnityEngine;

namespace OopProject1.Spawners
{
    public class RedDragonSpawner : BaseSpawner
    {
        protected override void Spawn()
        {
            EnemyController newEnemy = RedDragonPool.Instance.Get();
            newEnemy.transform.position = transform.position;
            newEnemy.gameObject.SetActive(true);
        }
    }
}

