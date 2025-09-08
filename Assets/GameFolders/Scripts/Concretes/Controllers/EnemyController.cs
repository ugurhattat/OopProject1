 using System.Collections;
using System.Collections.Generic;
using OopProject1.Abstracts.Controllers;
using OopProject1.Pools;
using UnityEngine;

namespace OopProject1.Controllers
{
    public abstract class EnemyController : LifeCycleController
    {
        public override void KillGameObject()
        {
            _currentTime = 0f;
            SetEnemyPool();
        }

        public abstract void SetEnemyPool();
    }
}