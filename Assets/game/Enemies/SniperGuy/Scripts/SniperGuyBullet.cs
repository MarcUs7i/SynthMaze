using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SniperGuyBullet : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 40;
    public Rigidbody2D rb;
    public GameObject impactEffect;

    void Start()
    {
        if (SniperGuy.BulletDirection == 0f)
        {
            rb.linearVelocity = -transform.right * speed;
        }
        if (SniperGuy.BulletDirection == 1f)
        {
            rb.linearVelocity = transform.right * speed;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            LevelMgr.killPlayer = true;
        }

        //Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
