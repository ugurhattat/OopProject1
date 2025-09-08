using OopProject1.Abstracts.Pools;
using OopProject1.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OopProject1.Pools
{
    public class RedDragonPool : GenericPool<RedDragonController>
    {
        public static RedDragonPool Instance { get; private set; }
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


