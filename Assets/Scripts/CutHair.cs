using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutHair : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource sound;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        AudioSource copy = Instantiate(sound);
        copy.Play();
    }
}
