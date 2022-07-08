using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NewScore : MonoBehaviour
{
    public static int heighscore = 0;
    private TMP_Text text;
    // Update is called once per frame

    void Start()
    {
        text = GetComponent<TMP_Text>();
    }

    void Update()
    {
        if(GameManager.ok == true)
        {
            if (heighscore < Score.score)
            {
                text.text = "new score:" + Score.score.ToString();
                heighscore = Score.score;
            }
            else
            {
                text.text = Score.score.ToString();
            }
            GameManager.ok = false;
        }
    }
}
