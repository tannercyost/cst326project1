using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //do something interesting to the ball, paddle, or some other game element
        Rigidbody collision = other.gameObject.GetComponent<Rigidbody>();
        Vector3 vel = collision.velocity;

        Vector3 scaleChange = new Vector3(-0.01f, -0.01f, -0.01f);
        collision.transform.localScale -= scaleChange;
    }
}
