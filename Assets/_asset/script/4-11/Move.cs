using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 0.01f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-1 * speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(1 * speed, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position += new Vector3(0, 1, 0);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            transform.position += new Vector3(0, 1, 0);
        }
    }
}
