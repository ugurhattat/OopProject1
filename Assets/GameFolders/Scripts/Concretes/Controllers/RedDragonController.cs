using OopProject1.Pools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OopProject1.Controllers
{
    public class RedDragonController : EnemyController
    {
        public override void SetEnemyPool()
        {
            RedDragonPool.Instance.Set(this);
        }
    }
}

