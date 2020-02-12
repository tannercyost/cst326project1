using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //do something interesting to the ball, paddle, or some other game element
        Rigidbody collision = other.gameObject.GetComponent<Rigidbody>();
        Vector3 vel = collision.velocity;
        collision.velocity = vel * 2;
    }
}
