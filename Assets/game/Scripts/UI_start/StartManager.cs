using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class StartManager : MonoBehaviour
{
    [Header("Scenes")]
    [Tooltip("The name of the Scene of Levels")]
    public string selectLevelScene = "SelectLevel";
    [Tooltip("The base name of levels")]
    public string baseLevelScene = "Level";
    [Tooltip("How many Levels there are")]
    public int levelCount = 20;
    [Tooltip("The name of about Scene")]
    public string aboutScene = "About";
    [Tooltip("The SceneFader Prefab")]
    public SceneFader sceneFader;

    [Header("GameObjects for SettingsClick")]
    public GameObject titleText;
    public GameObject startButton;
    public GameObject settingsButton;
    public GameObject settingsMenu;
    public static bool isInSettings = false;
    public static bool isInInfoMenu = false;
    public static bool isInDeleteMenu = false;

    [Header("Menus")]
    [Tooltip("GameObject for Info-Menu")]
    public GameObject infoMenu;
    [Tooltip("GameObject for Delete-Menu")]
    public GameObject deleteMenu;

    /*[Header("Variables for background")]
    public GameObject tilesGameObject;
    public float speedOfRotation = 2.0f;*/

    void Start()
    {
        isInSettings = false;
        isInInfoMenu = false;
        isInDeleteMenu = false;

        PlayerSaving.LoadingPlayer = true;

        //Test if something is null (not here / nicht anwesend) (VERY BAD)
        if(baseLevelScene == null) Debug.LogError("The Variablename 'nextScene' is null!");
        if(sceneFader == null) Debug.LogError("The Variablename 'sceneFader' is null!");
        if(titleText == null) Debug.LogError("The Variablename 'titleText' is null!");
        if(startButton == null) Debug.LogError("The Variablename 'startButton' is null!");
        if(settingsButton == null) Debug.LogError("The Variablename 'settingsButton' is null!");
        if(settingsMenu == null) Debug.LogError("The Variablename 'settingsMenu' is null!");
        if(infoMenu == null) Debug.LogError("The Variablename 'infoMenu' is null!");
        if(deleteMenu == null) Debug.LogError("The Variablename 'deleteMenu' is null!");
        //if(tilesGameObject == null) Debug.LogError("The Variablename 'tilesGameObject' is null!");

        //Debug.Log($"X: {Screen.width}; Y: {Screen.height}");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Tab) || Input.GetKeyDown(KeyCode.P))
        {
            ClickSettings();
        }
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Space))
        {
            ClickPlay();
        }

        //Just for test if SelectLevel works
        /*if (Input.GetKeyDown(KeyCode.O))
        {
            PlayerSaving.levels++;
            PlayerSaving.SavingPlayer = true;
            Debug.Log($"Saved {PlayerSaving.levels}");
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            PlayerSaving.levels--;
            PlayerSaving.SavingPlayer = true;
            Debug.Log($"Saved {PlayerSaving.levels}");
        }*/
    }

    public void ClickSettings()
    {
        isInSettings = !isInSettings;

        if (titleText != null) titleText.SetActive(!isInSettings);
        if (startButton != null) startButton.SetActive(!isInSettings);
        if (settingsButton != null) settingsButton.SetActive(!isInSettings);
        if (settingsMenu != null) settingsMenu.SetActive(isInSettings);
    }

    public void ClickInfo()
    {
        isInSettings = !isInSettings;
        isInInfoMenu = !isInInfoMenu;
        if (settingsMenu != null) settingsMenu.SetActive(!isInInfoMenu);
        if (infoMenu != null) infoMenu.SetActive(isInInfoMenu);
    }

    public void ClickDelete()
    {
        isInSettings = !isInSettings;
        isInDeleteMenu = !isInDeleteMenu;
        if (settingsMenu != null) settingsMenu.SetActive(!isInDeleteMenu);
        if (deleteMenu != null) deleteMenu.SetActive(isInDeleteMenu);
    }

    public void ClickPlay()
    {
        if (!isInSettings && !isInDeleteMenu && !isInInfoMenu)
        {
            if(PlayerSaving.levels >= levelCount) //Please change if smth is wrong with the last Level Fade.
            {
                sceneFader.FadeTo(aboutScene);
                return;
            }

            string level = baseLevelScene + $"{PlayerSaving.levels + 1}";
            //Fade To The New Scene
            sceneFader.FadeTo(level);
        }
    }

    public void ClickAbout()
    {
        if (isInSettings)
        {
            //Fade To The New Scene
            sceneFader.FadeTo(aboutScene);
        }
    }     

    public void ExitGame()
    {
        Debug.Log("Exciting...");
	    Application.Quit();
	    #if UNITY_EDITOR 
		    UnityEditor.EditorApplication.isPlaying = false;
	    #endif
    }
}