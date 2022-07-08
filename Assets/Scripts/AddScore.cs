using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{

    public AudioSource sound;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Score.score++;
        AudioSource copy = Instantiate(sound);
        copy.Play();
    }
}
