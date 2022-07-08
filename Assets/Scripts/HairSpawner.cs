using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HairSpawner : MonoBehaviour
{
    public float maxtime = 1;
    public GameObject Head;
    public float low = 0;
    public float high = 5;
    private float timer = 0;


    void Start()
    {
        GameObject newpipe = Instantiate(Head);
        newpipe.transform.position = transform.position + new Vector3(0, Random.Range(low, high), 0);
        maxtime = Random.Range(6, 10);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxtime)
        {
            GameObject newpipe = Instantiate(Head);
            newpipe.transform.position = transform.position + new Vector3(0, Random.Range(low, high), 0);
            newpipe.tag = "Hair";
            Destroy(newpipe, 15);
            timer = 0;
            maxtime = Random.Range(6, 10);
        }
        timer += Time.deltaTime;
    }
}
