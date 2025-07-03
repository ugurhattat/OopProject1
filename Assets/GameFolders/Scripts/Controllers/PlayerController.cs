using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OopProject1.Controllers
{

    
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] float jumpForce = 500f;
        //field private bir field'dir.
        Rigidbody2D _rigidbody2D;

        private void Awake()
        {
           _rigidbody2D = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                _rigidbody2D.AddForce(Vector2.up * jumpForce);
            }
        }
    }
}

