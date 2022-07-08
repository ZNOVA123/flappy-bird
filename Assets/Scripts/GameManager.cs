using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject canvas;
    public static bool ok = false;

    private void Start()
    {
        Time.timeScale = 1;
        canvas.SetActive(false);
        GameObject.Find("ScoreInGame").SetActive(true);
        ok = false;
    }

    public void GameOver()
    {
        ok = true;
        GameObject.Find("ScoreInGame").SetActive(false);
        canvas.SetActive(true);
        Time.timeScale = 0;

    }

    public void Replay()
    {

        SceneManager.LoadScene("Flappy");
    }


}
