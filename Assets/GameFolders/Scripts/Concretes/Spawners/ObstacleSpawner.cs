
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
            ObstaclePool pool = ObstaclePool.Instance;
            if (pool == null)
            {
                Debug.LogError("[ObstacleSpawner] ObstaclePool.Instance NULL! Sahneye ObstaclePool ekle/ ilk sahnede baslat");

                return;
            }

            EnemyController enemy = pool.Get();

            if (enemy == null)
            {
                Debug.LogError("[ObstacleSpawner] Pool NULL dondurdu. ObstaclePool icindeki 'Prefabs' dizisine en az 1 prefab ekle ve countLoop > 0 olsun.");

                return;
            }
            enemy.transform.position = this.transform.position;
            enemy.gameObject.SetActive(true);
        }
    }
}


