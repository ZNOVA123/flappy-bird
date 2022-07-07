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
        
       // GameObject child1 = originalGameObject.transform.GetChild(0).gameObject;
        //GameObject child2 = originalGameObject.transform.GetChild(1).gameObject;
        
        //child1.transform.position += new Vector3(pozx, pozy + gap, -1);
        //child1.transform.position += new Vector3(pozx, pozy - gap, -1);
    } 

    private static float pozx1, pozy1;
    void Start()
    {
        //GameObject child1 = originalGameObject.transform.GetChild(0).gameObject;
        //GameObject child2 = originalGameObject.transform.GetChild(1).gameObject;
        //child1.GetComponent<Transform>().position.
       // GapSetter(gap);
    }

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
