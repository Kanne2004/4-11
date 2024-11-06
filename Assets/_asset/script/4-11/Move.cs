using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 0.01f;
    public float jump = 3;
    public float traiPhai;
    public Rigidbody2D rb;
    public Animator anim;
    // Update is called once per frame
    void Update()
    {
        DiChuyen();
        Jump();
        Crouch();
        Kill();
        if (Input.GetMouseButtonDown(0)) // Bắn khi click chuột trái
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Vector2 direction = (mousePos - transform.position).normalized;

            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            bullet.GetComponent<Rigidbody2D>().velocity = direction * speed;
        }
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

        anim.SetFloat("move", Mathf.Abs(traiPhai));
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, jump);
            anim.SetFloat("jump", 1);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            anim.SetFloat("jump", 0);
        }
    }
    private void Crouch()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            anim.SetBool("crouch", true);
        }
        if (Input.GetKeyUp(KeyCode.S))
            anim.SetBool("crouch", false);

    }
    private void Kill()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            anim.SetFloat("die", 1);
        }
    }

}
