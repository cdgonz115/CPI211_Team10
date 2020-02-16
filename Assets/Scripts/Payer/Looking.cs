using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Looking : MonoBehaviour
{
    [SerializeField] public Text message;
    public GameObject bulletSpawn;

    void FixedUpdate()
    {
        RaycastHit hit;
        if ((Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity)))
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
            if (hit.collider.gameObject.tag == "Enemy")
            {
                bulletSpawn.GetComponent<LookAtEnemy>().lookTowards(hit.transform.position);
            }

        }
        else
        {
            message.text = " ";
        }
    }
    void OnDrawGizmosSelected()
    {
        // Draws a 5 unit long red line in front of the object
        Gizmos.color = Color.red;
        Vector3 direction = transform.TransformDirection(Vector3.forward) * 10;
        Gizmos.DrawRay(transform.position, direction);
    }
}