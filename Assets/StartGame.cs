using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject game;
    private void FixedUpdate()
    {
        if (Input.anyKeyDown)
        {
            transform.gameObject.SetActive(false);
            game.SetActive(true);
        }
    }
}
