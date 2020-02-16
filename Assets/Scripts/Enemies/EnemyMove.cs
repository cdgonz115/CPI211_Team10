using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(Rigidbody))]

public class EnemyMove : MonoBehaviour
{
    public float moveSpeed;
    public Transform target;
    public Transform enemies;
    Rigidbody rbody;

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = Random.Range(.05f, 4f);
        target = GameObject.FindGameObjectWithTag("Player").transform;
        rbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, target.position);
        if (distance >= 2)
        {
            enemies.position = Vector3.MoveTowards(enemies.position, target.position, Time.deltaTime * moveSpeed);
        }
        
    }
}