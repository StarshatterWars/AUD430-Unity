using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //Vector3 direction;
    float moveSpeed = 5f;
    public Transform player;
    //const float EPSILON = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        ChasePlayer();
    }

    void ChasePlayer()
    {
        /* direction = (player.position - transform.position).normalized;

        if((transform.position - player.position).magnitude > EPSILON)
        {
            transform.Translate(direction * Time.deltaTime * moveSpeed);
        } */
        
        transform.LookAt(player.position);
        transform.position = Vector3.MoveTowards(
            transform.position, player.position, moveSpeed * Time.deltaTime
        );
    }
}
