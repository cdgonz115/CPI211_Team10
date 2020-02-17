using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
public class DieKey : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {

            other.GetComponent<FirstPersonController>().keyUnlocked = true;
            Destroy(transform.parent.gameObject);
        }
    }
}
