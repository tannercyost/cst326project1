using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
    public AudioClip colSound;
    private AudioSource source;

    void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name != "UpperWall" && collision.gameObject.name != "LowerWall" && collision.gameObject.name != "Floor")
        {
            source.PlayOneShot(colSound, 1F);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
