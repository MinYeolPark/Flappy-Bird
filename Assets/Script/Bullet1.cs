using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet1 : MonoBehaviour
{
    private Rigidbody2D rb;
    public float maxSpeed = 30.0f;
    float Damage=1.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Destroy(gameObject, 5.0f);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = rb.transform.position;
        position = new Vector2(position.x + (1 * maxSpeed * Time.deltaTime), position.y);
        rb.MovePosition(position);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Obstacle")
        {
            Destroy(this.gameObject);
            Debug.Log("방해물과 충돌");
        }
        else if(collision.gameObject.tag=="Enemy")
        {
            Destroy(collision.gameObject);
        }
    }
}
