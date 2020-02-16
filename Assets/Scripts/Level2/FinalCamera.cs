using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalCamera : MonoBehaviour
{
    public GameObject ship;

    private void FixedUpdate()
    {
        transform.LookAt(ship.transform.position);
    }
}
