using System.Collections;
using System.Collections.Generic;
using OopProject1.Combats;
using OopProject1.Movements;
using UnityEngine;

namespace OopProject1.Controllers
{

    
    public class PlayerController : MonoBehaviour
    {
        Rigidbody2D _rigidbody2D;
        Jump _jump;
        PcInputController _input;
        LaunchProjectile _launchProjectile;
        AudioSource _audioSource;
        bool _isLeftMouseClicked;

        private void Awake()
        {
           _rigidbody2D = GetComponent<Rigidbody2D>();
            _jump = GetComponent<Jump>();
            _launchProjectile = GetComponent<LaunchProjectile>();
            _audioSource = GetComponent<AudioSource>();
            _input = new PcInputController();
        }

        private void Update()
        {
            if (_input.LeftMouseClickDown) 
            {
                _isLeftMouseClicked = true;
            }

            if (_input.RightMouseClickDown)
            {
                _launchProjectile.LaunchAction();
            }
        }

        private void FixedUpdate()
        {
            if (_isLeftMouseClicked)
            {
                _jump.JumpAction(_rigidbody2D);
                _audioSource.Play();
                _isLeftMouseClicked= false;
            }
        }
    }
}

