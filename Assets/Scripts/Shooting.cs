using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Shooting : MonoBehaviour
{
    public int InClip;
    private int WeaponClipSize;
    public int TotalAmmo;
    public float BulletSpeed;
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    private Rifle rifle;
  
    


    
    private void Start()
    {
        rifle = GetComponent<Rifle>();
        WeaponClipSize = rifle.ClipSize;
        InClip = WeaponClipSize;
        BulletSpeed = rifle.BulletSpeed;
        bulletPrefab=rifle.bulletPrefab;
        bulletSpawn=rifle.bulletSpawn;

}
    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && InClip != 0)
        {
            Fire();
            InClip--;
        }
        if (Input.GetKeyDown(KeyCode.R) && TotalAmmo >0 )
        {
            if(TotalAmmo>=WeaponClipSize)
            {
                TotalAmmo = TotalAmmo - WeaponClipSize;
                InClip = WeaponClipSize;
            }
            else
            {
                InClip = TotalAmmo;
                TotalAmmo = 0;
            }
        }

    }
    public string getInClip()
    {
        string temp = "" + InClip;
        return temp;
    }
    public string getAmmo()
    {
        string temp = "" + TotalAmmo;
        return temp;
    }
    void Fire()
    {
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * BulletSpeed;
        Destroy(bullet, 2.0f);

    }
    public void Reload()
    {
        TotalAmmo = TotalAmmo + WeaponClipSize;
    }
    

    // Update is called once per frame
    void Update ()
    {

	}
}
