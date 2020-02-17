using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class Teleporter : MonoBehaviour
{
    public Transform location;
    public bool teleported=false;
    [SerializeField] public Text message;

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            message.GetComponent<Text>().text = "";
        }
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.transform.tag == "Player")
        {
            if (other.GetComponent<FirstPersonController>().keyUnlocked)
            {
                other.GetComponent<CharacterController>().enabled = false;
                other.GetComponent<FirstPersonController>().m_GravityMultiplier = 1;
                other.GetComponent<FirstPersonController>().m_JumpSpeed= 15;
                other.transform.position = location.position;
                other.GetComponent<CharacterController>().enabled = true;
                teleported = true;
            }
            else 
            {
                message.GetComponent<Text>().text = "Key Needed";
            }

        }
    }
}
