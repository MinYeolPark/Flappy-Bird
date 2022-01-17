using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{
    //Player Itemget sound
    public AudioClip ItemClip;
    private AudioSource ItemgetSoundSource;

    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            ItemgetSoundSource.PlayOneShot(ItemClip);       //Active Once
        }
        
    }
}
