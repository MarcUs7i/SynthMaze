using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharpBlock : MonoBehaviour
{
    [Header("GameObjects")]
    private Rigidbody2D rb;
    public AudioSource audioSource;
    public Animator animator;

    [Header("Variables")]
    public float speed = 10;
    public float timeDelayOnHit = 5.0f;
    public bool isMovingRightOrUp = true;
    public bool horizontal = true;
    bool isChangingDirection = false;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator.SetInteger("AnimSpeedDecider", isMovingRightOrUp ? 1 : -1);
    }

    void Update()
    {
        if (Pause.IsPause)
        {
            rb.velocity = Vector2.zero;
        }
        else
        {
            if (horizontal)
            {
                if (isMovingRightOrUp && !isChangingDirection)
                {
                    rb.velocity = new Vector2(speed, rb.velocity.y);
                }
                else if (!isMovingRightOrUp && !isChangingDirection)
                {
                    rb.velocity = new Vector2(-speed, rb.velocity.y);
                }
            }
            else
            {
                if (isMovingRightOrUp && !isChangingDirection)
                {
                    rb.velocity = new Vector2(rb.velocity.x, speed);
                }
                else if (!isMovingRightOrUp && !isChangingDirection)
                {
                    rb.velocity = new Vector2(rb.velocity.x, -speed);
                }
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            StartCoroutine(ChangeDirection());
            audioSource.Play();
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

        yield return new WaitForSeconds(timeDelayOnHit / 2);

        isMovingRightOrUp = !isMovingRightOrUp;
        animator.SetInteger("AnimSpeedDecider", isMovingRightOrUp ? 1 : -1);

        yield return new WaitForSeconds(timeDelayOnHit / 2);
        isChangingDirection = false;
    }
}