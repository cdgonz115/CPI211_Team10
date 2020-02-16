using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    int enemyNum = 3;
    int keyTrigger = 5;
    public GameObject Enemy;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < enemyNum; i++)
        {
            SpawnEnemy();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (keyTrigger == 5)
        {

        }
        else if (keyTrigger != 5 && enemyNum < 3)
        {
            SpawnEnemy();
        }
    }

    private void SpawnEnemy()
    {
        Vector3 spawnPos = new Vector3(transform.position.x, transform.position.y, 0);
        GameObject octo = Instantiate(Enemy, spawnPos, Quaternion.identity) as GameObject;
        keyTrigger++;
    }
}
