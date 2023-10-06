using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyEnemySpawner : MonoBehaviour
{
    [SerializeField] Enemy enemyPrefab;

    Enemy enemy;

    public void Spawn()
    {
        if (enemy == null)
        {
            enemy = Instantiate(enemyPrefab, transform.position, transform.rotation);
        }
    }
}
