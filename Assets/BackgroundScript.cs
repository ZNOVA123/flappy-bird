using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScript : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public float speed = 1f;
    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        spriteRenderer.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0);
    }
}
