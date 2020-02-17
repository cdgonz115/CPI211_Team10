using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemiesUI : MonoBehaviour
{
    [SerializeField] public Text enemiesText;
    public GameObject spawner;
    public GameObject key;
    public int killed;
    public GameObject[] spawners;
    private void FixedUpdate()
    {
        
        if (killed == 30)
        {
            Instantiate(key, new Vector3(7, 16, 7), Quaternion.identity);
            killed++;
            enemiesText.text = "Get to the ship!!!";
            enemiesText.color = Color.blue;
            for (int x = 0; x < spawners.Length; x++)
            {
                spawners[x].SetActive(true);
            }
        }
        if (killed<30) enemiesText.text = "Enemies : " + (30 - killed);
    }
}
