using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class GravityController : MonoBehaviour
{
    public GameObject player;
    public int interval;
    public float timeLeft;

    private void Start() => timeLeft = interval;
    private void FixedUpdate()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            if (player.GetComponent<FirstPersonController>().m_GravityMultiplier == 1) player.GetComponent<FirstPersonController>().m_GravityMultiplier = 2;
            else player.GetComponent<FirstPersonController>().m_GravityMultiplier = 1;
            timeLeft = interval;
        }
    }

}
