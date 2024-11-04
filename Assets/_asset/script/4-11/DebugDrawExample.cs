using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugDrawExample : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(Vector3.zero, new Vector3(0, 1, 0), Color.red);
        Debug.DrawRay(Vector3.zero, Vector3.forward * 5, Color.green);
    }
}
