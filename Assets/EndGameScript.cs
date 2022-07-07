using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameScript : MonoBehaviour
{
    public Vector3 start, finish;
    public float time;
    private float timer;

    void Update()
    {
        timer += Time.deltaTime;
        float t = Mathf.Clamp01(timer / time);
        GetComponent<RectTransform>().anchoredPosition = Lerp(t);
    }

    private Vector3 Lerp(float t)
    {
        return (1 - t) * start + t * finish;
    }
}
