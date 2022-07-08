using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClassicButtonScript : MonoBehaviour
{
    public void PressStart()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
