using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public bool chamDat;
    public float speed = 5f;
    public float jump = 3;
    public float traiPhai;
    public float khoangTGDash;
    public float cdDash;
    public float speedDash = 15f;

    private float dashTime = 0f;
    private bool isDashing = false;     
    private float lastDashTime = -10f;


    public Rigidbody2D rb;
    public Animator anim;
    // Update is called once per frame
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        DiChuyen();
        Jump();
        canAttack();
        Crouch();
        HandleDash();
        Win();
        Die();

    }

    private void DiChuyen()
    {
        traiPhai = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(traiPhai * speed, rb.velocity.y);

        if (traiPhai < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        if (traiPhai > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }

        anim.SetBool("walk", traiPhai != 0);
    }
    private void Jump()
    {
        if (chamDat == true)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                rb.velocity = new Vector2(rb.velocity.x, jump);
                chamDat = false;
                if (Input.GetKey(KeyCode.J))
                {
                    anim.SetTrigger("flykick");
                }
            }
            anim.SetBool("jump", !chamDat);
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Dat"))
        {
            chamDat = true;
        }
    }
    public bool canAttack()
    {
        return traiPhai == 0;
    }
    private void Crouch()
    {
        if (Input.GetKey(KeyCode.S))
        {
            anim.SetBool("crouch", true);
        }
        else anim.SetBool("crouch", false);
    }
    private void Die()
    {
        if (Input.GetKey(KeyCode.Alpha0))
        {
            anim.SetBool("die", true);
        }
        else anim.SetBool("die", false);
    }
    private void Win()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            anim.SetBool("win", true);
        }
        else anim.SetBool("win", false);
    }
    void HandleDash()
    {
        // Dash logic - only allow if cooldown has passed
        if (Input.GetKeyDown(KeyCode.LeftShift) && Time.time >= lastDashTime + cdDash)
        {
            Dash();
        }

        // If currently dashing, track the time and stop after dashDuration
        if (isDashing)
        {
            dashTime += Time.deltaTime;
            if (dashTime >= khoangTGDash)
            {
                isDashing = false;
                rb.velocity = new Vector2(0, rb.velocity.y); // Stop dashing movement (freeze on X-axis)
                anim.SetBool("dash", false); // Stop dash animation
            }
        }
    }

    // Perform the dash, and trigger dash animation
    void Dash()
    {
        lastDashTime = Time.time; // Update the time of the last dash
        isDashing = true;          // Start dashing
        dashTime = 0f;             // Reset the dash timer

        // Apply the dash speed in the direction the player is facing
        rb.velocity = new Vector2(traiPhai * speed * speedDash, rb.velocity.y);

        // Trigger the dash animation
        anim.SetBool("dash", true); // Play "Dash" animation
    }
}

