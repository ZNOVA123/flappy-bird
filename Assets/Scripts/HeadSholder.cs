using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadSholder : MonoBehaviour
{
    public float speed;
    public AudioSource sound;
    void Start()
    {
        
    }

    // Update is called once per frame


    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
