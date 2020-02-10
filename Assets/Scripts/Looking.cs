using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Looking : MonoBehaviour
{
    [SerializeField] public Text message;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if ((Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 5, 1)))
        {

            if (hit.collider.gameObject.name == "Shotgun")
            {

                message.text = "Press E to Pick Up";
                if (Input.GetKeyDown(KeyCode.E))
                {
                    GetComponent<Weapons>().AddWeapon(hit.collider.gameObject);
                }
            }
            if (hit.collider.gameObject.tag == "Rifle Ammo")
            {
                message.text = "Press E to Pick Up Rifle Ammo";
                if (Input.GetKeyDown(KeyCode.E) && GetComponentInChildren<Rifle>() != null)
                {
                    GameObject.Find("Rifle").GetComponent<Rifle>().AmmoPickUp();
                    Destroy(hit.collider.gameObject);
                }
            }
            if (hit.collider.gameObject.tag == ("Shotgun Ammo"))
            {
                message.text = "Press E to Pick Up Shotgun Ammo";
                if (Input.GetKeyDown(KeyCode.E) && GetComponentInChildren<ShotGun>() != null)
                {
                    GameObject.Find("Shotgun").GetComponent<ShotGun>().AmmoPickUp();
                    Destroy(hit.collider.gameObject);
                }
            }

        }
        else
        {
            message.text = " ";
        }
    }
}