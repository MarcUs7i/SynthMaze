using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroy : MonoBehaviour
{
    public float time = 2;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RunAnimDestroy());
    }

    IEnumerator RunAnimDestroy()
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
}
