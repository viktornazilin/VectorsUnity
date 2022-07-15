using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorMath1 : MonoBehaviour
{
    public Vector3 V3;
    public Vector3 V4;

    private void OnDrawGizmos() 
    {
        Gizmos.color = Color.yellow;
        DrawVector(transform.position, V3);
        Gizmos.color = Color.black;
        DrawVector(transform.position, V4);
        Gizmos.color = Color.white;
        DrawVector(transform.position, V3 - V4);

        
    }

    private void DrawVector(Vector3 start, Vector3 vector)
    {
        Gizmos.DrawRay(start, vector);
        Gizmos.DrawSphere(start + vector, 0.2f);
    }
}
