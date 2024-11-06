using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 0.01f;
    public float jump = 3;
    public Animator anim;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            anim.SetFloat("move", 1);
            transform.position += new Vector3(-1 * speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            anim.SetFloat("move", 1);
            transform.position += new Vector3(1 * speed, 0, 0);
        }
        if (Input.GetKeyUp(KeyCode.A)|| Input.GetKeyUp(KeyCode.D))
        {
            anim.SetFloat("move", 0);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetFloat("jump", 1);
            transform.position += new Vector3(0, jump , 0);
            
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            anim.SetFloat("jump", 0);
        }
    }
}
