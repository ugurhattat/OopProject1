using System.Collections;
using System.Collections.Generic;
using OopProject1.Abstracts.Controllers;
using UnityEngine;

namespace OopProject1.Controllers
{
    public class ProjectileController : LifeCycleController
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            EnemyController enemy = collision.GetComponent<EnemyController>();

            if (enemy != null) 
            {
                GameManager.Instance.IncreaseScore();
                KillGameObject();
            }

            enemy.KillGameObject();
        }

        public override void KillGameObject()
        {
            Destroy(this.gameObject);
        }
    }
}