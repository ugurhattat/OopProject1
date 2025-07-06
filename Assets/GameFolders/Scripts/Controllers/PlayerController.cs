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
        bool _isLeftMouseClicked; //snake case _isLeftMouseClicked

        private void Awake()
        {
           _rigidbody2D = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            if (Input.GetMouseButton(0)) 
            {
                _isLeftMouseClicked = true;
            }
        }

        private void FixedUpdate()
        {
            if (_isLeftMouseClicked)
            {
                _rigidbody2D.velocity = Vector2.zero;
                _rigidbody2D.AddForce(Vector2.up * jumpForce);
                _isLeftMouseClicked= false;
            }
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            GameManager.Instance.RestartGame();
        }
    }
}

