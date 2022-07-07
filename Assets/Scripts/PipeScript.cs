using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public float gap, speed;
    void GameOver()
    {
        Debug.Log("S-a atins");
        
    }
    void OnTriggerEnter2D(Collider2D bird)
    {
        if (bird.name == "Bird")
            GameOver();
    }
    //GameObject originalGameObject = GameObject.Find("Pipe");
    void GapSetter(float gap)
    {
        transform.GetChild(0).position = new Vector3(pozx1, pozy1 - gap, -1);
        transform.GetChild(1).position = new Vector3(pozx2, pozy2 + gap, -1);
    } 

    private static float pozx1, pozy1, pozx2, pozy2;
    void Start()
    {
        pozx1 = transform.GetChild(0).position.x;
        pozy1 = transform.GetChild(0).position.y;
        pozx2 = transform.GetChild(1).position.x;
        pozy2 = transform.GetChild(1).position.y;
        GapSetter(gap);
    }

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
