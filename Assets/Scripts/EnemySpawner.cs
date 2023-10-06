using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] Enemy enemyPrefeb;

    Enemy enemy;

    public void Spawn()
    {
        if (enemy == null)
        {
            enemy = Instantiate(enemyPrefeb, transform.position, transform.rotation);
        }
    }
}
