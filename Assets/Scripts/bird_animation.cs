using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird_animation : MonoBehaviour
{
    public Sprite[] sprites;
    public int framesPerSecond;
    public float velocity;
    public bool isRotate;
    public Rigidbody2D rb;
    public GameManager gameManager;

    private SpriteRenderer spriteRenderer;
    private int currentSpriteIndex;
    private float timer;

    void Start()
    {
        transform.GetChild(0).gameObject.SetActive(false);
        spriteRenderer = GetComponent<SpriteRenderer>();
        currentSpriteIndex = 0;
        spriteRenderer.sprite = sprites[currentSpriteIndex];
        rb = GetComponent<Rigidbody2D>();
        if(isRotate == false)
            rb.freezeRotation = true;
    }

    private void Update()
    {

        timer += Time.deltaTime;

        if(Input.GetMouseButtonDown(0) || Input.GetButtonDown("Jump") || Input.GetMouseButton(0) || Input.GetButton("Jump"))
        {
            rb.velocity = Vector2.up * velocity;
        }

        if(isRotate == true)
        {
            float rotation = rb.velocity.y * 0.15f;

            if (transform.rotation.z > 0.18f && rotation > 0) rotation = 0;
            else if (transform.rotation.z < -0.4f && rotation < 0) rotation = 0;

            if (transform.rotation.eulerAngles.z < -60)
                rotation = -60;

            transform.Rotate(0, 0, rotation, Space.Self);
        }




        if (timer >= 1.0f / framesPerSecond)
        {
            currentSpriteIndex = (currentSpriteIndex + 1) % sprites.Length;
            spriteRenderer.sprite = sprites[currentSpriteIndex];

            timer -= 1.0f / framesPerSecond;
        }
    }

    private void RotateDown()
    {
        transform.Rotate(Vector3.forward * 90);
    }

    private void OnCollisionEnter2D(Collision2D collision2D)
    {
        
        if(collision2D.collider.tag == "Hair")
        {
            transform.GetChild(0).gameObject.SetActive(true);
            Destroy(collision2D.gameObject);
        }
        else
        {
            transform.GetChild(0).gameObject.SetActive(false);
            gameManager.GameOver();
        }
            
    }
}
