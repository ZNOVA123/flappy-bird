using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    // Start is called before the first frame update
    public void PressStart()
    {
        SceneManager.LoadScene("ChooseMenu"); 
    }


}
