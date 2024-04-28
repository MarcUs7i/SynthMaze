using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public static bool IsPause = false;
    public GameObject CoinCounterUI;
    public GameObject PauseButton;
    public GameObject PauseMenu;
    //public Animator animator; // remove '//' for Shanti Manti

    void Start()
    {
        CoinCounterUI.SetActive(true);
        PauseButton.SetActive(true);
        PauseMenu.SetActive(false);
        IsPause = false;
    }

    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Tab) || Input.GetKeyDown(KeyCode.P)))
		{
		    PauseGame();
	    }
    }

    public void PauseGame()
    {
        IsPause = !IsPause;
        PauseMenu.SetActive(IsPause);
        PauseButton.SetActive(!IsPause);
        CoinCounterUI.SetActive(!IsPause);
    }
}
