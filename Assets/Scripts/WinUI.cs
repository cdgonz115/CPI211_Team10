﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinUI : MonoBehaviour
{
    [SerializeField] public Text gameStatusText;
    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
    private void FixedUpdate()
    {
        if (AI.enemyCount <= 0)
        {
            gameStatusText.text = "You Won!!!";
        }
    }
}
