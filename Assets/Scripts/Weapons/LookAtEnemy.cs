using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtEnemy : MonoBehaviour
{
    public void lookTowards(Vector3 enemy)
    {
        transform.LookAt(enemy);
    }
}
