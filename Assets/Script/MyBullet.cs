using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;

[RequireComponent(typeof(Rigidbody))]
public class MyBullet : MonoBehaviour
{
    [SerializeField] float speed = 20f;

    // Start is called before the first frame update
    void Start()
    {
        var velocity = speed * transform.forward;

        var rigidbody = GetComponent<Rigidbody>();

        rigidbody.AddForce(velocity, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        other.SendMessage("OnHitBullet");

        Destroy(gameObject);
    }
}
