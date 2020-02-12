using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponUI : MonoBehaviour
{
    [SerializeField] public Text weaponID;
    string id;
    // Use this for initialization
    void Start ()
    {
		id="";
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
    private void FixedUpdate()
    {
        id = GetComponent<Weapons>().getID();
        weaponID.text = id;
    }
}
