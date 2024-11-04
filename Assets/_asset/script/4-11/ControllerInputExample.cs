using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerInputExample : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Debug.Log("Controller Input - Horizontal: " + horizontal + ", Vertical: " +
        vertical);
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("Jump button was pressed.");
        }

    }
}
