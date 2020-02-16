using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
public class Teleporter : MonoBehaviour
{
    public Transform location;
    private void OnTriggerEnter(Collider other)
    {

        if (other.transform.tag == "Player")
        {
            print(other.gameObject.name);
            other.GetComponent<CharacterController>().enabled = false;
            other.GetComponent<FirstPersonController>().m_GravityMultiplier = 1;
            other.transform.position = location.position;
            other.GetComponent<CharacterController>().enabled = true;
        }
    }
}
