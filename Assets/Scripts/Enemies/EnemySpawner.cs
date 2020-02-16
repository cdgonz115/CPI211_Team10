using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    private int enemies;
    public GameObject Enemy;
    private float timeLeft;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            SpawnEnemy();
        }
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (enemies < 10)
        {
            if (timeLeft <= 0)
            {
                SpawnEnemy();
            }
            else if (enemies <= 0)
            {
                SpawnEnemy();
            }
        }
        
    }

    private void SpawnEnemy()
    {
        GameObject octo = Instantiate(Enemy, transform.position, Quaternion.identity);
        timeLeft = Random.Range(5f, 10f);
        enemies++;
    }
}
