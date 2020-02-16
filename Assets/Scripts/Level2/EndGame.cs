using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public GameObject cam;
    public FlyAway fl;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") 
        {
            
            other.gameObject.SetActive(false);
            cam.SetActive(true);
            fl.enabled = true;
            
        }
    }
}
