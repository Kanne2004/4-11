using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInputExample : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Ban vua nhan Space.");
        }
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("Ban dang giu W.");
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            Debug.Log("Ban vua tha W.");
        }
    }
}
