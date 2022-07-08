using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScript : MonoBehaviour
{
    public void PressRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void OnMouseDown()
    {
        PressRestart();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PressRestart();
        }
    }
}
