using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : MonoBehaviour
{
    public int InClip;
    public int ClipSize;
    public int MaxAmmo;
    private int TotalAmmo;
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public int BulletSpeed;
    public string id;
    public GameObject player;

    // Use this for initialization
    void Start ()
    {
        id = "Rifle";
        InClip = ClipSize;
        TotalAmmo = InClip;
    }
    private void FixedUpdate()
    {

            if (Input.GetKeyDown(KeyCode.Mouse0) && InClip != 0)
            {
                Fire();
                InClip--;
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                Reload();
            }
        

    }

    // Update is called once per frame
    void Update ()
    {
		
	}
    void Fire()
    {

            GameObject bullet = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
            bullet.transform.Rotate(new Vector3(-90,0,0));
            bullet.GetComponent<Rigidbody>().velocity = player.GetComponent<Rigidbody>().velocity - bullet.transform.up * BulletSpeed;
            Destroy(bullet, 2.0f);
    }
    public void Reload()
    {
        if (TotalAmmo > 0 && InClip < ClipSize)
        {
            int temp = ClipSize - InClip;
            if (TotalAmmo >= temp)
            {
                TotalAmmo = TotalAmmo - temp;
                InClip = InClip + temp;
            }
            else
            {
                InClip = InClip + TotalAmmo;
                TotalAmmo = 0;
            }
        }
    }
    public void AmmoPickUp()
    {
        if (TotalAmmo < MaxAmmo)
        {
            int temp = MaxAmmo - TotalAmmo;
            if (temp >= ClipSize)
            {
                TotalAmmo = TotalAmmo + ClipSize;
            }
            else
            {
                TotalAmmo = TotalAmmo + temp;
            }
        }
    }
    public string getAmmoText()
    {
        string temp = InClip + "/" + TotalAmmo;
        return temp;
    }
    public string getID()
    {
        return id;
    }

}
