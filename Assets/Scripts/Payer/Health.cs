using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Health : MonoBehaviour
{
    [SerializeField] public Text ht;
    public int health;
    private bool inv;
    private float timeLeft;
    public GameObject deathcam;

    private void Start() => ht.text = "Health: "+health;
    public void takeDamage()
    {
        if (timeLeft<0)
        {
            health--;
            ht.text = "Health: " + health;
            timeLeft = 1;
        }
    }
    private void FixedUpdate()
    {
        timeLeft -= Time.deltaTime;
        if (health <= 0)
        {
            gameObject.SetActive(false);
            deathcam.SetActive(true);

        }
    }
        
}
