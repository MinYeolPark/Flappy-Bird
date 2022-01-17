using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyBird : MonoBehaviour
{
    public GameManager gameManager;

    public LifeScript healthBar;

    public int curHealth = 0;
    public int maxHealth = 1;
    
    public float velocity = 1;
    private Rigidbody2D rb;

    //Player Jump sound
    public AudioClip jumpClip;
    private AudioSource jumpSoundSource;

    //Player Dead sound
    public AudioClip dieClip;
    private AudioSource dieSoundSource;



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jumpSoundSource = GetComponent<AudioSource>();
        dieSoundSource = GetComponent<AudioSource>();

        curHealth = maxHealth;
        healthBar.setMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.velocity = Vector2.up * velocity;
            jumpSoundSource.PlayOneShot(jumpClip);
        }
        transform.eulerAngles = new Vector3(0, 0, rb.velocity.y*15);    //rotate bird
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            DamagePlayer(1);             
        }
        else
        {
            DamagePlayer(1);
        }

        if(curHealth<=0)
        {
            dieSoundSource.PlayOneShot(dieClip);
            gameManager.GameOver();
            gameManager.bgmSoundSource.Stop();
        }
    }
    public void DamagePlayer(int damage)
    {
        curHealth -= damage;
        healthBar.SetHealth(curHealth);
    }
}
