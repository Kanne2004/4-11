using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInputExample : MonoBehaviour
{
    [SerializeField] private float mouseX;
    [SerializeField] private float mouseY;
    // Update is called once per frame
    void Update()
    {
        //0: chuot trai  |  1: chuot phai  |  2: chuot giua
        if (Input.GetMouseButtonDown(0)) //nhap vao du lieu khi an chuot trai
        {
            Debug.Log("Ban vua nhan chuot trai!");
        }
        if (Input.GetMouseButton(1)) //nhap vao du lieu khi giu chuot phai
        {
            Debug.Log("Ban dang giu chuot phai");
        }
        if (Input.GetMouseButtonUp(0)) ////nhap vao du lieu khi tha chuot trai
        {
        Debug.Log("Ban vua tha chuot trai!");
        }
        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");
        //Debug.Log("Mouse Movement - X: " + mouseX + ", Y: " + mouseY);
    }
}
