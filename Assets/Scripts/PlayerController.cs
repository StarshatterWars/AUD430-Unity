using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 30f;
    private float maxSpeed = 5.0f;
    private Rigidbody rb;
    // constructor labs <---
    MovementBoundaries boundaries;

    // Start is called before the first frame update
    void Start()
    {
        HowToPlay();
        rb = GetComponent<Rigidbody>();
        // Constructor example lab - 3 //
        boundaries = gameObject.AddComponent<MovementBoundaries>();
        ///////////////////////////////////////////////////////
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MoveV1();
    }

    void HowToPlay()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Use 'WASD or arrow keys' to move your player");
    }

    void MoveV1()
    {
        boundaries.CheckBoundaries();
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, 0, zValue);
    }

    void MoveV2()
    {
        boundaries.CheckBoundaries();
        float xValue = Input.GetAxis("Horizontal");
        float zValue = Input.GetAxis("Vertical") ;
        Vector3 input = new Vector3(xValue, 0.0f, zValue);
        if(rb.velocity.magnitude < maxSpeed)
        {
            rb.AddForce(input * moveSpeed);
        }
    }

}
