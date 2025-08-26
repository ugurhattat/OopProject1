using System.Collections;
using System.Collections.Generic;
using OopProject1.Abstracts.Controllers;
using UnityEngine;

namespace OopProject1.Controllers
{
    public class ProjectileController : LifeCycleController
    {
        private void OnCollisionEnter2D(Collision2D collision)
        {
            Debug.Log("Collision Enter 2d triggered");
        }
    }

}