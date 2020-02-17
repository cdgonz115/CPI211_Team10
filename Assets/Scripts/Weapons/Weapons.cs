using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour
{
    public List<GameObject> weapons;
    private int WeaponLocation;
    
	// Use this for initialization
	void Start ()
    {
        weapons.Add(GameObject.Find("Rifle"));
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
    public void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Q) || Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            SwapWeapon();
        }
    }
    public void AddWeapon(GameObject passed)
    {
        foreach(GameObject weapon in weapons)
        {
            weapon.SetActive(false);
        }

        weapons.Add(passed);
        passed.transform.SetParent(GameObject.Find("FirstPersonCharacter").transform);
        passed.GetComponent<Collider>().enabled = false;
        passed.gameObject.transform.localRotation = Quaternion.Euler(new Vector3(90, 0, 0));
        passed.gameObject.transform.localPosition = new Vector3(.5f, -0.8f, 0.5f);
        WeaponLocation =weapons.IndexOf(passed);
        weapons[WeaponLocation].SetActive(true);
    }
    public void SwapWeapon()
    {
        weapons[WeaponLocation].SetActive(false);

        if (WeaponLocation == weapons.Count-1)
        {
            WeaponLocation = 0;
        }
        else
        {
            WeaponLocation++;
        }

        weapons[WeaponLocation].SetActive(true);

    }
    public GameObject GetWeapon()
    {
        return weapons[WeaponLocation];
    }
    public string getAmmo()
    {
        string temp="";
        if(weapons[WeaponLocation].name == "Rifle")
        {
            if(GameObject.Find("Rifle")) temp = GameObject.Find("Rifle").GetComponent<Rifle>().getAmmoText();
        }
        else if(weapons[WeaponLocation].name == "Shotgun")
        {
            temp = GameObject.Find("Shotgun").GetComponent<ShotGun>().getAmmoText();
        }
        return temp;
    }
    public string getID()
    {
        string temp = "";
        if (weapons[WeaponLocation].name == "Shotgun")
        {
            temp = GameObject.Find("Shotgun").GetComponent<ShotGun>().getID();
        }
        if (weapons[WeaponLocation].name == "Rifle")
        {
            temp = GameObject.Find("Rifle").GetComponent<Rifle>().getID();
        }
        return temp;
    }


}
