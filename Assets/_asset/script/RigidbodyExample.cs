using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyExample : MonoBehaviour
{
    public Rigidbody myRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody.mass = 5.0f; //khoi luong vat the (kg)
        myRigidbody.velocity = Vector3.one;
    }
}
