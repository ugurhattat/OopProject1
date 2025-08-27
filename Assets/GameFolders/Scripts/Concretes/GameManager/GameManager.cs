using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] int score;
    public static GameManager Instance { get; private set; }

    public event System.Action<int> OnScoreChanged;

    private void Awake()
    {
        SingletonThisGameObject();
    }

    private void SingletonThisGameObject()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void IncreaseScore()
    {
        score += 10;
        OnScoreChanged?.Invoke(score);
    }

    public void RestartGame()
    {
        StartCoroutine(RestartGameAsync());
    }

    private IEnumerator RestartGameAsync()
    {
        yield return SceneManager.LoadSceneAsync("Game");
    }
}
