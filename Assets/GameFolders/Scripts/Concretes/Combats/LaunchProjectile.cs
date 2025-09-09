using OopProject1.Controllers;
using OopProject1.Pools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OopProject1.Combats
{
    public class LaunchProjectile : MonoBehaviour
    {
        [SerializeField] ProjectileController projectilePrefab;
        [SerializeField] Transform projectileTransform;
        [SerializeField] float delayProjectile = 0.1f;

        float _currentDelayTime;
        bool _canLaunch = false;  //0 ve 1 / 0=> false / 1=>true

        private void Update()
        {
            _currentDelayTime += Time.deltaTime;

            if (_currentDelayTime > delayProjectile)
            {
                _canLaunch = true;
                _currentDelayTime = 0f;
            }
        }

        public void LaunchAction()
        {
            if (!_canLaunch) return;

            if (ProjectilePool.Instance == null)
            {
                Debug.LogError("[LaunchProjectile] ProjectilePool.Instance NULL! Sahneye 'ProjectilePool' ekle veya ilk sahnede DontDestroyOnLoad ile baslat.");

                return;
            }

            var newProjectile = ProjectilePool.Instance.Get();

            if (newProjectile == null)
            {
                Debug.LogError("[LaunchProjectile] Pool NULL dondurdu. ProjectilePool icindeki 'Prefabs' dizisine en az 1 prefab ekle");

                return;
            }

            if (projectileTransform == null)
            {
                Debug.LogError("[LaunchProjectile] projectileTransform (FirePoint) atanmamis");

                return;
            }

                newProjectile.transform.position = projectileTransform.position;
                newProjectile.gameObject.SetActive(true);
                _canLaunch = false;
        }
    }
 
}