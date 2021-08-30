using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shark : MonoBehaviour
{
    Rigidbody2D rb;         // declare object for Rigidbody 2D component for the shark
    
    bool isJumping;

    public GameManager gameManager;

    AudioSource jumpSound;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isJumping = false;

        jumpSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space") && isJumping == false)
        {
            rb.velocity = new Vector3(0, 20, 0);
            isJumping = true;

            jumpSound.Play();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isJumping = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "obstacle")
        {
            gameManager.GameOver();
        }
    }
}
