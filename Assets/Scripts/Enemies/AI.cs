using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AI : MonoBehaviour
{
    public float enemyHealth;
    private float health;
    public static int enemyCount;
    public Image healthBar;
    
    // Use this for initialization
    void Start ()
    {
        health = enemyHealth;
        enemyCount++;
	}
	
	// Update is called once per frame
	void Update ()
    {

	}
    private void FixedUpdate()
    {
        if (health <=0)
        {
            
            DestroyGameObject();
            enemyCount--;
        }
        healthBar.fillAmount =(health / enemyHealth);
 
    }

    public void LowerHealth(int inputDamage)
    {
        health=health-inputDamage;
    }
    private void OnCollisionEnter(Collision collision)  
    {
        if(collision.gameObject.tag=="Bullet")
        {
            Bullet bullet = collision.gameObject.GetComponent<Bullet>();
            int damagePassed = bullet.getDamage();
            LowerHealth(damagePassed);
            Destroy(collision.gameObject);
        }
        
    }

    void DestroyGameObject()
    {
        Destroy(gameObject);
    }
}
