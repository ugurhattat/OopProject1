using OopProject1.Pools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OopProject1.Controllers
{
    public class ObstacleController : EnemyController
    {
        public override void SetEnemyPool()
        {
            ObstaclePool.Instance.Set(this);
        }
    }
}

