using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SniperGuy : MonoBehaviour
{
    [Header("GameObjects")]
    public AudioSource audioSource;
    public Animator animator;
    public GameObject bullet;
    public Transform firePoint;

    [Header("Variables")]
    public float timeDelay = 1.0f;
    public float timeWait = 3.0f;

    //non-GUI variables
    bool IsAttacking = false;
    float direction;

    public static float BulletDirection = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (audioSource == null) Debug.LogError("audioSource is null");
        if (animator == null) Debug.LogError("animator is null");

        float rotationY = transform.localRotation.eulerAngles.y;
        // If the rotation is close to 0 or 180 degrees, it's facing right
        // If the rotation is close to 180 or 360 degrees, it's facing left
        if (rotationY < 90f || rotationY > 270f)
        {
            direction = 1;
        }
        else
        {
            direction = 0;
        }
        BulletDirection = direction;
    }

    // Update is called once per frame
    void Update()
    {
        if(!Pause.IsPause)
        {
            StartCoroutine(RunScript());
        }
    }

    IEnumerator RunScript()
    {
        if (IsAttacking) yield break;
        IsAttacking = true;
        //wait
        yield return new WaitForSeconds(timeWait);

        //attack
        animator.SetBool("IsAttacking", true);
        audioSource.Play();
        Instantiate(bullet, firePoint.position, firePoint.rotation);

        //wait
        yield return new WaitForSeconds(timeDelay);

        //stop attack
        animator.SetBool("IsAttacking", false);
        audioSource.Stop();
        IsAttacking = false;
    }
    
}
