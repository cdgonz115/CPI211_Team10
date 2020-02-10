using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {

        if (hit.gameObject.tag == "Rifle Ammo")
        {
           
        }
        if (hit.gameObject.tag == "Shotgun Ammo")
        {
            GameObject.Find("Shotgun").GetComponent<ShotGun>().AmmoPickUp(); ;
            Destroy(hit.gameObject);
        }
    }
}
