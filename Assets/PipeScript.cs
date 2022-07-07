using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public float gap;
    public int sus_sau_jos;
    void GameOver()
    {

    }
    void OnTriggerEnter2D(Collider2D bird)
    {
        if (bird.name == "Bird")
            GameOver();
    }

    void GapSetter(float gap, int sus_sau_jos)
    {
        transform.position = new Vector3(pozx, pozy + (gap * sus_sau_jos), -1);
    } 

    private float pozx, pozy;
    void Start()
    {
        pozx = GetComponent<Transform>().position.x;
        pozy = GetComponent<Transform>().position.y;
        GapSetter(gap, sus_sau_jos);
    }

    void Update()
    {
        
    }
}
