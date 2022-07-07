using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject canvas;

    private void Start()
    {
        canvas.SetActive(false);
        GameObject.Find("ScoreInGame").SetActive(true);
    }

    public void GameOver()
    {
        GameObject.Find("ScoreInGame").SetActive(false);
        canvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void Replay()
    {

        SceneManager.LoadScene("Flappy");
    }

}
