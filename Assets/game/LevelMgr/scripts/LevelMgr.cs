using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMgr : MonoBehaviour
{
    [Header("Scenes")]
    public string levelToLoad = "Level2";
    public string mainMenu = "Start";
    public SceneFader sceneFader;
    public static int level = 0;
    public int SetLevel = 1;
    //public static bool nextLevel = false;
    public static int LevelForCoinBool = 0;
    public int EndCoins = 3;

    [Header("If lastLevel -> ClearData")]
    public bool clearDataAfterLevel = false;

    [Header("Animators")]
    public Animator animator;
    public Animator playerAnimator;
    public Animator nextLevelAnimator;
    public Animator restartButtonAnimator;

    [Header("GameObjects")]
    public GameObject stageCleared;
    public GameObject stageLost;

    [Header("Variables")]
    public float waitForReloadInSeconds = 0.1f;
    public static float steps = 0;
    public int SetCoins = 3;

    //non-GUI variables
    bool alreadyDisplayedKilled = false;
    //non-GUI static variables
    public static bool MultipleTriggered = false;
    public static bool BackToMain = false;
    public static bool killPlayer = false;

    void Awake()
    {
        GetComponent<Collider2D>().isTrigger = true;
        //level = PlayerSaving.levels;
        PlayerSaving.LoadingPlayer = true;
        level = SetLevel - 1;
        Debug.Log(level);
        steps = 0;
        killPlayer = false;
        animator.SetBool("nextLevel", false);
        PlayerMove.StopMoving = false;
        playerAnimator.SetBool("Stop", false);
        nextLevelAnimator.SetBool("CanGoToNextLevel", false);
        restartButtonAnimator.SetBool("RestartPressed", false);

        if(stageCleared == null) Debug.LogError("stageCleared not set!");
        else stageCleared.SetActive(false);

        if(stageLost == null) Debug.LogError("stageLost not set!");
        else stageLost.SetActive(false);

        if(level == 0)
        {
            SC_2DCoin.totalCoins = 0;
        }

        if(level >= 1)
        {
            SC_2DCoin.totalCoins = SetCoins;
        }
    }

    void OnTriggerEnter2D(Collider2D c2d)
    {
        // Stage 2: If all coins are collected, then check if the player collides with the LevelMgr, then the Player cant move and its invisible
        if (c2d.CompareTag("Player") && steps == 1)
        {
            MultipleTriggered = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.X) && steps <= 1)
        {
            RestartLevelPressed();
        }
        if (Input.GetKeyDown(KeyCode.C) && steps <= 1)
        {
            CameraController.pressCameraButton = true;
        }

        if(!alreadyDisplayedKilled && killPlayer)
        {
            //killPlayer = false;
            DieAndKillPlayer();
        }

        //Debug.Log(level);
        if (level != PlayerSaving.levels && PlayerSaving.Deleteing == false)
        {
            if (PlayerSaving.levels < level)
            {
                PlayerSaving.levels = level;
                PlayerSaving.SavingPlayer = true;
                //Debug.Log("Saved " + PlayerSaving.levels + " Level");
            }
        }

        LevelForCoinBool = SetLevel;


        // Stage 1: check if all coins are collected
        if (SC_2DCoin.totalCoins == EndCoins && steps == 0)
        {
            steps = 1;
            //animator.SetBool("nextLevel", true);
        }

        if(Input.GetKeyDown(KeyCode.V) && !killPlayer)
        {
            NextLevelPressed();
        }
        else if(Input.GetKeyDown(KeyCode.V) && killPlayer)
        {
            StartCoroutine(waitForReload());
        }

        if(MultipleTriggered)
        {
            PlayerMove.StopMoving = true;
            playerAnimator.SetBool("Stop", true);
            nextLevelAnimator.SetBool("CanGoToNextLevel", true);
            stageCleared.SetActive(true);
            steps = 2;
            MultipleTriggered = false;
        }
        
    }

    public void RestartLevelPressed()
    {
        restartButtonAnimator.SetBool("RestartPressed", true);
        level = SetLevel - 1;
        if(level == 0)
        {
            SC_2DCoin.totalCoins = 0;
        }

        if(level >= 1)
        {
            SC_2DCoin.totalCoins = SetCoins;
        }
        StartCoroutine(waitForReload());
    }

    public void NextLevelPressed()
    {
        if (steps == 2)
        {
            level = SetLevel;
            Debug.Log(level);
            StartCoroutine(NextLevelPressedDelete());
        }
    }

    public void DieAndKillPlayer()
    {
        alreadyDisplayedKilled = true;
        PlayerMove.StopMoving = true;
        playerAnimator.SetBool("Stop", true);
        nextLevelAnimator.SetBool("CanGoToNextLevel", true);
        stageLost.SetActive(true);
    }


    public void ExitLevel()
    {
        sceneFader.FadeTo(mainMenu);
    }

    IEnumerator waitForReload()
    {
        BackToMain = true;
        SoundBar.SceneReloaded = true;
        yield return new WaitForSeconds(waitForReloadInSeconds);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        BackToMain = false;
    }

    IEnumerator NextLevelPressedDelete()
    {
        if(clearDataAfterLevel)
        {
            PlayerSaving.Deleteing = true;
            yield return new WaitForSeconds(.5f);
            PlayerSaving.LoadingPlayer = true;
            PlayerSaving.Deleteing = true;
        }
        SoundBar.SceneReloaded = true;
        Debug.Log(PlayerSaving.levels);
        sceneFader.FadeTo(levelToLoad);
    }
}
