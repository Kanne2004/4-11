using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmosExample : MonoBehaviour
{
    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(transform.position, 0.5f);
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.up);
    }
}
