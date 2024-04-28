using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleLevel : MonoBehaviour
{
    public Animator animator;

    void Awake()
    {
        GetComponent<Collider2D>().isTrigger = true;
        animator.SetBool("nextLevel", false);
    }

    void OnTriggerEnter2D(Collider2D c2d)
    {
        // Stage 2: If all coins are collected, then check if the player collides with the LevelMgr, then the Player cant move and its invisible
        if (c2d.CompareTag("Player") && LevelMgr.steps == 1)
        {
            LevelMgr.MultipleTriggered = true;

        }
    }

    void Update()
    {
        if(LevelMgr.steps == 1)
        {
            animator.SetBool("nextLevel", true);
        }
    }
}
