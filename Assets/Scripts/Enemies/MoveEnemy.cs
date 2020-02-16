using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    public float moveSpeed;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = Random.Range(5f, moveSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, target.position);
        transform.LookAt(target);
        if (distance >= 2)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, Time.deltaTime * moveSpeed);
        }

    }
}