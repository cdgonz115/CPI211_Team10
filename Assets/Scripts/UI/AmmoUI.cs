using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoUI : MonoBehaviour
{

    [SerializeField] public Text ammoText;
    string ammo;

    // Use this for initialization
    void Start ()
    {
        ammo = "";
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
    private void FixedUpdate()
    {
        ammo = GetComponent<Weapons>().getAmmo();
        ammoText.text = ammo;
    }
}
