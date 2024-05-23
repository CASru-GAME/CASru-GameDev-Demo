using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private ScoreManager scoreManager;

    [SerializeField] private GameObject textGameOver;
    [SerializeField] private GameObject textGameClear;

    [SerializeField] private float accel = 0.4f;

    private static float _timeScale = 1;
    private bool gameStoprFlag = false;

    

    private void Start()
    {
        Time.timeScale = _timeScale;
    }

    private void Update()
    {
        if (gameStoprFlag && Input.GetKey(KeyCode.Space))
        {
            stageReLoad();
        }
    }

    public void gameClear()
    {
        Time.timeScale = 0;
        _timeScale += accel;
        ScoreManager.score++;
        textGameClear.SetActive(true);
        gameStoprFlag = true;
    }

    public void gameOver()
    {
        Time.timeScale = 0;
        _timeScale = 1;
        ScoreManager.score = 0;
        textGameOver.SetActive(true);
        gameStoprFlag = true;
    }

    public void stageReLoad()
    {
        SceneManager.LoadScene("GameScene");
    }

    
}
