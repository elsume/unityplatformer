using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float patrolDistance = 3f;
    
    private Vector3 startPosition;
    private int direction = 1;
    
    void Start()
    {
        startPosition = transform.position;
    }
    
    void Update()
    {
        transform.position += new Vector3(direction * moveSpeed * Time.deltaTime, 0, 0);
        
        float distanceFromStart = transform.position.x - startPosition.x;
        
        if (distanceFromStart > patrolDistance)
        {
            transform.position = new Vector3(startPosition.x + patrolDistance, transform.position.y, transform.position.z);
            direction = -1;
        }
        else if (distanceFromStart < -patrolDistance)
        {
            transform.position = new Vector3(startPosition.x - patrolDistance, transform.position.y, transform.position.z);
            direction = 1;
        }
    }
}