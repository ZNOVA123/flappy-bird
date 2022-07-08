using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject canvas;
    public static bool ok = false;
    public static int heighscore = 0;

    private void Start()
    {
        Time.timeScale = 1;
        ok = false;
        canvas.SetActive(false);
        GameObject.Find("ScoreInGame").SetActive(true);
    }

    public void GameOver()
    {
        GameObject.Find("ScoreInGame").SetActive(false);
        ok = true;
        canvas.SetActive(true);
        Time.timeScale = 0;

    }

    public void Replay()
    {

        SceneManager.LoadScene("Flappy");
    }


}
