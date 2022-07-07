using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score = 0;
    private TMP_Text text;

    void Start()
    {
        score = 0;
        text = GetComponent<TMP_Text>();
    }
    
    void Update()
    {
        text.text = score.ToString();
    }
}
