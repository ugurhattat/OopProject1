using OopProject1.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OopProject1.Combats
{
    public class LaunchProjectile : MonoBehaviour
    {
        [SerializeField] ProjectileController projectilePrefab;
        [SerializeField] Transform projectileTransform;
        [SerializeField] GameObject projectileParent;
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

            if (_canLaunch)
            {
                ProjectileController newProjectile = Instantiate(projectilePrefab, projectileTransform.position, projectileTransform.transform.rotation);

                newProjectile.transform.parent = projectileParent.transform;

                _canLaunch = false;
            }
        }
    }
 
}