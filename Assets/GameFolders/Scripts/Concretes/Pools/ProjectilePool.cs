using OopProject1.Abstracts.Pools;
using OopProject1.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OopProject1.Pools
{
    public class ProjectilePool : GenericPool<ProjectileController>
    {
        public static ProjectilePool Instance { get; private set; }

        public override void ResetAllObjects()
        {
            foreach (ProjectileController child in GetComponentsInChildren<ProjectileController>())
            {
                if (!child.gameObject.activeSelf) continue;

                child.KillGameObject();
            }
        }

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

