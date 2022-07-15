using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public Vector3 RotationVelocity;


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(RotationVelocity * Time.deltaTime);
    }
}
