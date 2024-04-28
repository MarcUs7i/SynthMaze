using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarcPresents : MonoBehaviour
{
    public SceneFader sceneFader;
    public string levelToLoad = "Start";
    public float timeToWait = 7.0f;
    

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartScene());
    }

    IEnumerator StartScene()
    {
        yield return new WaitForSeconds(timeToWait);
        SoundBar.SceneReloaded = true;
        sceneFader.FadeTo(levelToLoad);
    }

}
