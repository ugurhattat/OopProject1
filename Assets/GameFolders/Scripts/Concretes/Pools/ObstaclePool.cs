using OopProject1.Abstracts.Pools;
using OopProject1.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OopProject1.Pools
{
    public class ObstaclePool : GenericPool<EnemyController>
    {
        public static ObstaclePool instance { get; private set; }

        protected override void SingletonObject()
        {
            if (instance == null)
            {
                instance = this;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }
    }
}

