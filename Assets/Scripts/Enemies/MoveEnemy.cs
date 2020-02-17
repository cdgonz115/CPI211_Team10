using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    public float moveSpeed;
    //public Transform target;
    //public GameObject wtf;

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = Random.Range(5f, moveSpeed);
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (GameObject.Find("FPSController"))
        {

            float distance = Vector3.Distance(transform.position, GameObject.Find("FPSController").GetComponent<Transform>().position);
            transform.LookAt(GameObject.Find("FPSController").GetComponent<Transform>().position);
            if (distance >= 2)
            {

                transform.position = Vector3.MoveTowards(transform.position, GameObject.Find("FPSController").GetComponent<Transform>().position, Time.deltaTime * moveSpeed);
            }
            else GameObject.Find("FPSController").GetComponent<Health>().takeDamage();

        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(-307, 12, 169), Time.deltaTime * moveSpeed);
        }

    }
    
}