using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] AudioClip spawnClip;
    [SerializeField] AudioClip hitClip;

    [SerializeField] Collider enemyColloder;
    [SerializeField] Renderer enemyRenderer;

    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();

        audioSource.PlayOneShot(spawnClip);
    }

    void OnHitBullet()
    {
        Destroy(gameObject);

        GoDown();
    }

    void GoDown()
    {
        enemyColloder.enabled = false;
        enemyRenderer.enabled = false;

        Destroy(gameObject, 1f);
    }
}
