using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("message.");
        Debug.LogWarning("warning message.");
        Debug.LogError("error message.");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
