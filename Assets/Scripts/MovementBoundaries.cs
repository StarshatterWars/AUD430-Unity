using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBoundaries : MonoBehaviour
{
    private float xMax = 9.2f;
    private float xMin = -9.2f;
    private float zMax = 9.2f;
    private float zMin = -9.2f;

    public void CheckBoundaries()
    {
        float xMovement = Mathf.Clamp(transform.position.x, xMin, xMax);
        float zMovement = Mathf.Clamp(transform.position.z, zMin, zMax);
        transform.position = new Vector3(xMovement, transform.position.y, zMovement);
    }
}
