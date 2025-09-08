
using OopProject1.Abstracts.Spawners;
using OopProject1.Controllers;
using OopProject1.Pools;
using UnityEngine;



namespace OopProject1.Spawners
{
    public class ObstacleSpawner : BaseSpawner
    {
        protected override void Spawn()
        {
            EnemyController poolEnemy = ObstaclePool.instance.Get();
            poolEnemy.transform.position = this.transform.position;
            poolEnemy.gameObject.SetActive(true);
        }
    }
}


