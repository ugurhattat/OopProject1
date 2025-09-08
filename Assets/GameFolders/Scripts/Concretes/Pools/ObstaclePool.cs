using OopProject1.Abstracts.Pools;
using OopProject1.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OopProject1.Pools
{
    public class ObstaclePool : GenericPool<ObstacleController>
    {
        public static ObstaclePool Instance { get; private set; }

        protected override void SingletonObject()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }
    }
}

