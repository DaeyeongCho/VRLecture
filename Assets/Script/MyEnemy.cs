using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyEnemy : MonoBehaviour
{
    void OnHitBullet()
    {
        Destroy(gameObject);
    }
}
