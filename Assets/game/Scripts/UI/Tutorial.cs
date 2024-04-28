using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    private Button level1;

    // Start is called before the first frame update
    void Awake()
    {
        level1 = GetComponent<Button>();
        level1.interactable = false;
        StartCoroutine(WaitForTutorial());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator WaitForTutorial()
    {
        yield return new WaitForSeconds(4.0f);
        level1.interactable = true;
    }
}
