using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject canvas;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {

        canvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void Replay()
    {

        SceneManager.LoadScene(0);
    }
}
