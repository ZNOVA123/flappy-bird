using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CustomButtonScript : MonoBehaviour
{
    public void PressStart()
    {
        SceneManager.LoadScene("CustomScene");
    }
}
