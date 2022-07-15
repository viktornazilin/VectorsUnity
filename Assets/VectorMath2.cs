using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorMath2 : MonoBehaviour
{
    public Transform V1;
    public Transform V2;

    private void OnDrawGizmos() 
    {
        if (V1 == null || V2 == null) return;
        Gizmos.color = Color.yellow;
        Vector3 vector1 = V1.position;
        DrawVector(transform.position, vector1);
        Gizmos.color = Color.black;
        Vector3 vector2 = V2.position;
        DrawVector(transform.position, vector2);

        Vector3 cross = Vector3.Cross(vector1.normalized, vector2.normalized);
        Gizmos.color = Color.green;
        DrawVector(transform.position, cross);

        float distance = Vector3.Distance(V1.transform.position, V2.transform.position);
        Debug.Log(distance);
             
    }

    private void DrawVector(Vector3 start, Vector3 vector)
    {
        Gizmos.DrawRay(start, vector);
        Gizmos.DrawSphere(start + vector, 0.2f);
    }
}
