using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

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
    public AudioSource ads;
    [SerializeField] private AudioClip[] sounds;
    public GameObject tel;

    // Use this for initialization
    void Start ()
    {
        id = "Rifle";
        InClip = ClipSize;
        TotalAmmo = MaxAmmo;
    }
    private void FixedUpdate()
    {

            if (Input.GetKeyDown(KeyCode.Mouse0) && InClip != 0)
            {
                Fire();
                if (tel.GetComponentInChildren<Teleporter>().teleported)
                {
                    ads.PlayOneShot(sounds[1]);
                    ads.volume = 1;
                }
                else
                {
                    ads.PlayOneShot(sounds[0]);
                    ads.volume = .75f;
                }
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
            InClip--;
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
