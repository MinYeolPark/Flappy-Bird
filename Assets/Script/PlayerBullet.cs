using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public GameObject bulletPrefab;

    public AudioClip shotClip;
    private AudioSource shotSoundSource;
    void Start()
    {
        shotSoundSource = GetComponent<AudioSource>();
        gameObject.layer = LayerMask.NameToLayer("Default");
    }

      void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlaySound();            
            Instantiate(bulletPrefab, transform.position, transform.rotation);            
        }
    }
    void PlaySound()
    {
        if (shotSoundSource.isPlaying) return;
            shotSoundSource.PlayOneShot(shotClip);       //Active Once
    }
}
