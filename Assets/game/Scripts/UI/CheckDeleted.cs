using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckDeleted : MonoBehaviour
{
    public GameObject Error;
    public GameObject Deleted;
    public GameObject ThisDeleting;
    int count = 0;
    bool waitDelete = false;
    public float WaitTime = 2.0f;
    public float waitTimeExit = 3.0f;
    bool waitExit = false;
    int Delete = 0;
    int Exit = 0;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        waitDelete = false;
        Delete = 0;
        Exit = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Delete Stage: " + count);
        if (count == 0)
        {
            if (Exit == 0)
            {
                StartCoroutine(WaitForExit());
            }
            if (waitExit)
            {
                return;
            }
            count++;
            Exit = 0;
            if (PlayerSaving.levels == 0 && PlayerSaving.savedCoins == 0 && PlayerSaving.tutorial == 0)
            {
                
                Deleted.SetActive(true);
                Debug.Log("Done Stage: " + count);
                count = 0;
                ThisDeleting.SetActive(false);
            }
        }
        if (count == 1 || count == 2)
        {
            PlayerSaving.DeleteingPlayer = true;
            if (Delete == 0)
            {
                StartCoroutine(WaitForDelete());
            }
            if (waitDelete)
            {
                return;
            }
            PlayerSaving.LoadingPlayer = true;
        	count++;
            Delete = 0;
            if (PlayerSaving.levels == 0 && PlayerSaving.savedCoins == 0 && PlayerSaving.tutorial == 0)
            {
                Deleted.SetActive(true);
                Debug.Log("Done Stage: " + count);
                count = 0;
                ThisDeleting.SetActive(false);
            }
        }
        if (count >= 3)
        {
            Error.SetActive(true);
            Debug.Log("Failed Stage: " + count);
            count = 0;
            ThisDeleting.SetActive(false);
        }
    }

    IEnumerator WaitForDelete()
    {
        Delete++;
        waitDelete = true;
        yield return new WaitForSeconds(WaitTime);
        waitDelete = false;
        
    }

    IEnumerator WaitForExit()
    {
        if (Exit == 0)
        {
            Exit++;
            waitExit = true;
            yield return new WaitForSeconds(waitTimeExit);
            waitExit = false;
        }
        
    }
}
