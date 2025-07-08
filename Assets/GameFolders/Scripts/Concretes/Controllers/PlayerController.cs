using System.Collections;
using System.Collections.Generic;
using OopProject1.Movements;
using UnityEngine;

namespace OopProject1.Controllers
{

    
    public class PlayerController : MonoBehaviour
    {
        Rigidbody2D _rigidbody2D;
        Jump _jump;
        PcInputController _input;
        bool _isLeftMouseClicked;

        private void Awake()
        {
           _rigidbody2D = GetComponent<Rigidbody2D>();
            _jump = GetComponent<Jump>();
            _input = new PcInputController();
        }

        private void Update()
        {
            if (_input.LeftMouseClickDown) 
            {
                _isLeftMouseClicked = true;
            }
        }

        private void FixedUpdate()
        {
            if (_isLeftMouseClicked)
            {
                _jump.JumpAction(_rigidbody2D);

                _isLeftMouseClicked= false;
            }
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            GameManager.Instance.RestartGame();
        }
    }
}

