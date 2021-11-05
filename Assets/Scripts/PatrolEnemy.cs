using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolEnemy : MonoBehaviour
{
    // lab 4 content
    float moveSpeed = 5f;
    public Transform[] patrolPoints;
    int randomPoint;
    float idleTime;
    float startIdleTime = 3;
    //
    // Start is called before the first frame update
    void Start()
    {
        randomPoint = Random.Range(0, patrolPoints.Length);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Patrol();
    }

    void Patrol()
    {
        transform.position = Vector3.MoveTowards(
            transform.position, patrolPoints[randomPoint].position,
            moveSpeed * Time.deltaTime
        );

        if(Vector3.Distance(transform.position, patrolPoints[randomPoint].position) < 0.1f)
        {
            if(idleTime <= 0)
            {
                randomPoint = Random.Range(0, patrolPoints.Length);
                idleTime = startIdleTime;
            }
            else
            {
                idleTime -= startIdleTime;
            }
        }
    }
}
