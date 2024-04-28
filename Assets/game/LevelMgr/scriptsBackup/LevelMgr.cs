/*using System.Collections;
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
    [Header("GameObjects")]
    public GameObject objPlayer1;
    public GameObject objPlayer2;

    [Header("Animators")]
    public Animator animator;
    public Animator nextLevelAnimator;
    public Animator restartButtonAnimator;
    [Header("Some Variables")]
    public float waitForReloadInSeconds = 0.1f;
    public static float steps = 0;
    public int SetCoins = 3;
    public static bool MultipleTriggered = false;
    public static bool BackToMain = false;

    void Awake()
    {
        GetComponent<Collider2D>().isTrigger = true;
        //level = PlayerSaving.levels;
        PlayerSaving.LoadingPlayer = true;
        level = SetLevel - 1;
        Debug.Log(level);
        steps = 0;
        animator.SetBool("nextLevel", false);
        PlayerMove.StopMoving = false;
        nextLevelAnimator.SetBool("CanGoToNextLevel", false);
        restartButtonAnimator.SetBool("RestartPressed", false);

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
        if(Input.GetKeyDown(KeyCode.X))
        {
            RestartLevelPressed();
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

        if(Input.GetKeyDown(KeyCode.V))
        {
            NextLevelPressed();
        }

        if(MultipleTriggered && !PlayerMove.hasTwoPlayer)
        {
            PlayerMove.StopMoving = true;
            PlayerMove.stopAnimator = true;
            nextLevelAnimator.SetBool("CanGoToNextLevel", true);
            steps = 2;
            MultipleTriggered = false;
        }
        if(MultipleTriggered && PlayerMove.hasTwoPlayer)
        {
            //PlayerMove.StopMoving = true;
            //PlayerMove.stopAnimator = true;
            PlayerMove.deletePlayer = 3;
            
            if(objPlayer1 == null && objPlayer2 == null)
            {
                nextLevelAnimator.SetBool("CanGoToNextLevel", true);
                steps = 2;
            }
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
        Debug.Log(PlayerSaving.levels);
        sceneFader.FadeTo(levelToLoad);
    }
}
*/