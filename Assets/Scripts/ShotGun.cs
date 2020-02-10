using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotGun : MonoBehaviour
{
    public int InClip;
    public int ClipSize;
    private int TotalAmmo;
    public int MaxAmmo;
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public int BulletSpeed;
    public string id;

    // Use this for initialization
    void Start()
    {
        id = "ShotGun";
        InClip = ClipSize;
        TotalAmmo = InClip;

        
    }
    private void FixedUpdate()
    {
        
        if(this.transform.parent!=null && this.transform.parent.name=="FirstPersonCharacter")
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
            


    }

    // Update is called once per frame
    void Update()
    {

    }
    void Fire()
    {

            GameObject bullet1 = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.transform.rotation);
            bullet1.GetComponent<Rigidbody>().velocity = -bullet1.transform.forward * BulletSpeed;
            Destroy(bullet1, 2.0f);
            GameObject bullet2 = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.transform.rotation);
            bullet2.GetComponent<Rigidbody>().velocity =-bullet2.transform.forward * BulletSpeed + bullet2.transform.up;
            Destroy(bullet2, 2.0f);
            GameObject bullet3 = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.transform.rotation);
            bullet3.GetComponent<Rigidbody>().velocity = -bullet3.transform.forward * BulletSpeed + -bullet3.transform.up;
            Destroy(bullet3, 2.0f);
            GameObject bullet4 = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.transform.rotation);
            bullet4.GetComponent<Rigidbody>().velocity = -bullet4.transform.forward * BulletSpeed + bullet4.transform.right;
            Destroy(bullet4, 2.0f);
            GameObject bullet5 = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.transform.rotation);
            bullet5.GetComponent<Rigidbody>().velocity = -bullet5.transform.forward * BulletSpeed + -bullet5.transform.right;
            Destroy(bullet5, 2.0f);
            

    }
    public void Reload()
    {
        if(TotalAmmo > 0 && InClip < ClipSize)
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
