using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe_spawner : MonoBehaviour
{
    public float maxtime = 1;
    public GameObject pipe;
    public float height;
    private float timer = 0;

    void Start()
    {
        GameObject newpipe = Instantiate(pipe);
        newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > maxtime)
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newpipe, 15);

        }
        timer += Time.deltaTime;
    }
}
