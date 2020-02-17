using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCameraBack : MonoBehaviour
{
    public float timeLeft = 10;
    void Start()
    {
        GetComponent<Rigidbody>().velocity = -transform.forward * 25;

    }
    private void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0) Application.Quit();
    }
}
