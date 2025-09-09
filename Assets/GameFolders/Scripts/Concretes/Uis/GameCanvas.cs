using OopProject1.Combats;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OopProject1.Uis
{
    public class GameCanvas : MonoBehaviour
    {
        [SerializeField] private GameObject gameOverPanel;

        private Dead _dead;

        private void Awake()
        {
            if (gameOverPanel == null)
            {
                Debug.LogWarning("[GameCanvas] gameOverPanel atanmadi");
            }
            else
            {
                gameOverPanel.SetActive(false);
            }
        }

        private void OnEnable()
        {
            if (_dead == null)
            {
                _dead = FindFirstObjectByType<Dead>();
            }

            if (_dead != null)
            {
                _dead.OnDead += HandleOnDead;
            }

            else
            {
                Debug.LogWarning("[GameCanvas] Dead bileseni sahnede bulunamadi");
            }
        }

        private void OnDisable()
        {
            if (_dead != null)
            {
                _dead.OnDead -= HandleOnDead;
            }
        }

        private void HandleOnDead()
        {
            if (gameOverPanel != null)
            {
                gameOverPanel.SetActive(true);

                Time.timeScale = 0f;
            }

        }
    }
}


