using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe_spawnerHard : MonoBehaviour
{
    public float maxtime = 1;
    public GameObject pipe;
    public float low = 0;
    public float high = 5;
    private float timer = 0;


    void Start()
    {
        GameObject newpipe = Instantiate(pipe);
        newpipe.transform.position = transform.position + new Vector3(0, Random.Range(low, high), 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxtime)
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = transform.position + new Vector3(0, Random.Range(low, high), 0);
            newpipe.transform.Rotate(0, 0, Random.Range(-30, 30), Space.Self);
            Destroy(newpipe, 15);
            timer = 0;

        }
        timer += Time.deltaTime;
    }
}
