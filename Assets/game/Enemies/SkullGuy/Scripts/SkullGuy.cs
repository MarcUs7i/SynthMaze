using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkullGuy : MonoBehaviour
{
    [Header("GameObjects")]
    private Rigidbody2D rb;
    public Animator animator;

    [Header("Variables")]
    public float speed = 0;
    public float timeDelayOnHit = 1.0f;
    public bool isMovingRight = true;
    bool isChangingDirection = false;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator.SetInteger("AnimSpeedDecider", isMovingRight ? 1 : -1);
    }

    void Update()
    {
        if (Pause.IsPause)
        {
            rb.velocity = Vector2.zero;
        }
        else
        {
            if (isMovingRight && !isChangingDirection)
            {
                rb.velocity = new Vector2(speed, rb.velocity.y);
            }
            else if (!isMovingRight && !isChangingDirection)
            {
                rb.velocity = new Vector2(-speed, rb.velocity.y);
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            StartCoroutine(ChangeDirection());
        }
        
        if (collision.gameObject.CompareTag("Player"))
        {
            LevelMgr.killPlayer = true;
        }
    }

    IEnumerator ChangeDirection()
    {
        isChangingDirection = true;
        rb.velocity = Vector2.zero;
        
        yield return new WaitForSeconds(timeDelayOnHit/2);

        isMovingRight = !isMovingRight;
        animator.SetInteger("AnimSpeedDecider", isMovingRight ? 1 : -1);

        yield return new WaitForSeconds(timeDelayOnHit/2);
        isChangingDirection = false;
    }
}