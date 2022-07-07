using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartScript : MonoBehaviour
{
    public void PressStart()
    {
        SceneManager.LoadScene("SampleScene");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PressStart();
        }
    }
}
