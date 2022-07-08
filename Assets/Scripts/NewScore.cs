using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NewScore : MonoBehaviour
{
    
    private TMP_Text text1;
    // Update is called once per frame

    void Start()
    {
        text1 = GetComponent<TMP_Text>();
    }

    void Update()
    {
        if(GameManager.ok == true)
        {
            if (GameManager.heighscore < Score.score)
            {
                text1.text = "New Highscore : " + Score.score.ToString();
                GameManager.heighscore = Score.score;
            }
            else
            {
                text1.text = "Highscore : " + Score.score.ToString(); ;
            }
            GameManager.ok = false;
        }
        
    }
}
