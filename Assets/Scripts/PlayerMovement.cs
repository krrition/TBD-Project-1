using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private float horizontal;
    public float moveSpeed;
    public Rigidbody2D playerRb;
    public Animator anim;

    public AudioSource AS;

    public bool isfacingRight = false;

    private Vector2 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        AS = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //Process Inputs
        //ProcessInputs();
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY).normalized;
        if (moveX < 0 && isfacingRight)
        {
            Flip();
        }
        else if (moveX > 0 && !isfacingRight)
        {
            Flip();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (playerRb.velocity.x != 0)
        {
            if (!AS.isPlaying)
            {
                AS.Play();
            }
        }
        else
        {
            AS.Stop();
        }    
    }

    void FixedUpdate()
    {
        //Process calculations
        Move();
        anim.SetFloat("xVelocity", Math.Abs(playerRb.velocity.x));
    }

    /*void ProcessInputs()
    {

    }*/

    void Move()
    {
        playerRb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }

    private void Flip()
    {
        isfacingRight = !isfacingRight;
        transform.Rotate(0f, 180f, 0f);
    }
}
