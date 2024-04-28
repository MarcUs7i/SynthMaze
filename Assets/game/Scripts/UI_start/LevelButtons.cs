using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelButtons : MonoBehaviour
{
    public Button level1;
    public Button level2;
    public Button level3;
    public Button level4;
    public Button level5;
    public Button level6;
    public Button level7;
    public Button level8;
    public Button level9;
    public Button level10;
    public Button level11;
    public Button level12;
    public Button level13;
    public Button level14;
    public Button level15;
    public Button level16;
    public Button level17;
    public Button level18;
    public Button level19;
    public Button level20;
    public Button bonus;
    public Button about;

    public int test = 0;

    // Start is called before the first frame update
    void Awake()
    {
        level1.interactable = true;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerSaving.LoadingPlayer = true;
        test = PlayerSaving.levels;

        /*if (Input.GetKeyDown(KeyCode.U))
		{
			test--;
		}
        if (Input.GetKeyDown(KeyCode.I))
		{
			test++;
		}*/

        if (test == 0)
        {
            level1.interactable = true;
            level2.interactable = false;
            level3.interactable = false;
            level4.interactable = false;
            level5.interactable = false;
            level6.interactable = false;
            level7.interactable = false;
            level8.interactable = false;
            level9.interactable = false;
            level10.interactable = false;
            level11.interactable = false;
            level12.interactable = false;
            level13.interactable = false;
            level14.interactable = false;
            level15.interactable = false;
            level16.interactable = false;
            level17.interactable = false;
            level18.interactable = false;
            level19.interactable = false;
            level20.interactable = false;
            bonus.interactable = false;
            about.interactable = true;
        }
        if (test == 1)
        {
            level1.interactable = true;
            level2.interactable = true;
            level3.interactable = false;
            level4.interactable = false;
            level5.interactable = false;
            level6.interactable = false;
            level7.interactable = false;
            level8.interactable = false;
            level9.interactable = false;
            level10.interactable = false;
            level11.interactable = false;
            level12.interactable = false;
            level13.interactable = false;
            level14.interactable = false;
            level15.interactable = false;
            level16.interactable = false;
            level17.interactable = false;
            level18.interactable = false;
            level19.interactable = false;
            level20.interactable = false;
            bonus.interactable = false;
            about.interactable = true;
        }
        if (test == 2)
        {
            level1.interactable = true;
            level2.interactable = true;
            level3.interactable = true;
            level4.interactable = false;
            level5.interactable = false;
            level6.interactable = false;
            level7.interactable = false;
            level8.interactable = false;
            level9.interactable = false;
            level10.interactable = false;
            level11.interactable = false;
            level12.interactable = false;
            level13.interactable = false;
            level14.interactable = false;
            level15.interactable = false;
            level16.interactable = false;
            level17.interactable = false;
            level18.interactable = false;
            level19.interactable = false;
            level20.interactable = false;
            bonus.interactable = false;
            about.interactable = true;
        }
        if (test == 3)
        {
            level1.interactable = true;
            level2.interactable = true;
            level3.interactable = true;
            level4.interactable = true;
            level5.interactable = false;
            level6.interactable = false;
            level7.interactable = false;
            level8.interactable = false;
            level9.interactable = false;
            level10.interactable = false;
            level11.interactable = false;
            level12.interactable = false;
            level13.interactable = false;
            level14.interactable = false;
            level15.interactable = false;
            level16.interactable = false;
            level17.interactable = false;
            level18.interactable = false;
            level19.interactable = false;
            level20.interactable = false;
            bonus.interactable = false;
            about.interactable = true;
        }
        if (test == 4)
        {
            level1.interactable = true;
            level2.interactable = true;
            level3.interactable = true;
            level4.interactable = true;
            level5.interactable = true;
            level6.interactable = false;
            level7.interactable = false;
            level8.interactable = false;
            level9.interactable = false;
            level10.interactable = false;
            level11.interactable = false;
            level12.interactable = false;
            level13.interactable = false;
            level14.interactable = false;
            level15.interactable = false;
            level16.interactable = false;
            level17.interactable = false;
            level18.interactable = false;
            level19.interactable = false;
            level20.interactable = false;
            bonus.interactable = false;
            about.interactable = true;
        }
        if (test == 5)
        {
            level1.interactable = true;
            level2.interactable = true;
            level3.interactable = true;
            level4.interactable = true;
            level5.interactable = true;
            level6.interactable = true;
            level7.interactable = false;
            level8.interactable = false;
            level9.interactable = false;
            level10.interactable = false;
            level11.interactable = false;
            level12.interactable = false;
            level13.interactable = false;
            level14.interactable = false;
            level15.interactable = false;
            level16.interactable = false;
            level17.interactable = false;
            level18.interactable = false;
            level19.interactable = false;
            level20.interactable = false;
            bonus.interactable = false;
            about.interactable = true;
        }
        if (test == 6)
        {
            level1.interactable = true;
            level2.interactable = true;
            level3.interactable = true;
            level4.interactable = true;
            level5.interactable = true;
            level6.interactable = true;
            level7.interactable = true;
            level8.interactable = false;
            level9.interactable = false;
            level10.interactable = false;
            level11.interactable = false;
            level12.interactable = false;
            level13.interactable = false;
            level14.interactable = false;
            level15.interactable = false;
            level16.interactable = false;
            level17.interactable = false;
            level18.interactable = false;
            level19.interactable = false;
            level20.interactable = false;
            bonus.interactable = false;
            about.interactable = true;
        }
        if (test == 7)
        {
            level1.interactable = true;
            level2.interactable = true;
            level3.interactable = true;
            level4.interactable = true;
            level5.interactable = true;
            level6.interactable = true;
            level7.interactable = true;
            level8.interactable = true;
            level9.interactable = false;
            level10.interactable = false;
            level11.interactable = false;
            level12.interactable = false;
            level13.interactable = false;
            level14.interactable = false;
            level15.interactable = false;
            level16.interactable = false;
            level17.interactable = false;
            level18.interactable = false;
            level19.interactable = false;
            level20.interactable = false;
            bonus.interactable = false;
            about.interactable = true;
        }
        if (test == 8)
        {
            level1.interactable = true;
            level2.interactable = true;
            level3.interactable = true;
            level4.interactable = true;
            level5.interactable = true;
            level6.interactable = true;
            level7.interactable = true;
            level8.interactable = true;
            level9.interactable = true;
            level10.interactable = false;
            level11.interactable = false;
            level12.interactable = false;
            level13.interactable = false;
            level14.interactable = false;
            level15.interactable = false;
            level16.interactable = false;
            level17.interactable = false;
            level18.interactable = false;
            level19.interactable = false;
            level20.interactable = false;
            bonus.interactable = false;
            about.interactable = true;
        }
        if (test == 9)
        {
            level1.interactable = true;
            level2.interactable = true;
            level3.interactable = true;
            level4.interactable = true;
            level5.interactable = true;
            level6.interactable = true;
            level7.interactable = true;
            level8.interactable = true;
            level9.interactable = true;
            level10.interactable = true;
            level11.interactable = false;
            level12.interactable = false;
            level13.interactable = false;
            level14.interactable = false;
            level15.interactable = false;
            level16.interactable = false;
            level17.interactable = false;
            level18.interactable = false;
            level19.interactable = false;
            level20.interactable = false;
            bonus.interactable = false;
            about.interactable = true;
        }
        if (test == 10)
        {
            level1.interactable = true;
            level2.interactable = true;
            level3.interactable = true;
            level4.interactable = true;
            level5.interactable = true;
            level6.interactable = true;
            level7.interactable = true;
            level8.interactable = true;
            level9.interactable = true;
            level10.interactable = true;
            level11.interactable = true;
            level12.interactable = false;
            level13.interactable = false;
            level14.interactable = false;
            level15.interactable = false;
            level16.interactable = false;
            level17.interactable = false;
            level18.interactable = false;
            level19.interactable = false;
            level20.interactable = false;
            bonus.interactable = false;
            about.interactable = true;
        }
        if (test == 11)
        {
            level1.interactable = true;
            level2.interactable = true;
            level3.interactable = true;
            level4.interactable = true;
            level5.interactable = true;
            level6.interactable = true;
            level7.interactable = true;
            level8.interactable = true;
            level9.interactable = true;
            level10.interactable = true;
            level11.interactable = true;
            level12.interactable = true;
            level13.interactable = false;
            level14.interactable = false;
            level15.interactable = false;
            level16.interactable = false;
            level17.interactable = false;
            level18.interactable = false;
            level19.interactable = false;
            level20.interactable = false;
            bonus.interactable = false;
            about.interactable = true;
        }
        if (test == 12)
        {
            level1.interactable = true;
            level2.interactable = true;
            level3.interactable = true;
            level4.interactable = true;
            level5.interactable = true;
            level6.interactable = true;
            level7.interactable = true;
            level8.interactable = true;
            level9.interactable = true;
            level10.interactable = true;
            level11.interactable = true;
            level12.interactable = true;
            level13.interactable = true;
            level14.interactable = false;
            level15.interactable = false;
            level16.interactable = false;
            level17.interactable = false;
            level18.interactable = false;
            level19.interactable = false;
            level20.interactable = false;
            bonus.interactable = false;
            about.interactable = true;
        }
        if (test == 13)
        {
            level1.interactable = true;
            level2.interactable = true;
            level3.interactable = true;
            level4.interactable = true;
            level5.interactable = true;
            level6.interactable = true;
            level7.interactable = true;
            level8.interactable = true;
            level9.interactable = true;
            level10.interactable = true;
            level11.interactable = true;
            level12.interactable = true;
            level13.interactable = true;
            level14.interactable = true;
            level15.interactable = false;
            level16.interactable = false;
            level17.interactable = false;
            level18.interactable = false;
            level19.interactable = false;
            level20.interactable = false;
            bonus.interactable = false;
            about.interactable = true;
        }
        if (test == 14)
        {
            level1.interactable = true;
            level2.interactable = true;
            level3.interactable = true;
            level4.interactable = true;
            level5.interactable = true;
            level6.interactable = true;
            level7.interactable = true;
            level8.interactable = true;
            level9.interactable = true;
            level10.interactable = true;
            level11.interactable = true;
            level12.interactable = true;
            level13.interactable = true;
            level14.interactable = true;
            level15.interactable = true;
            level16.interactable = false;
            level17.interactable = false;
            level18.interactable = false;
            level19.interactable = false;
            level20.interactable = false;
            bonus.interactable = false;
            about.interactable = true;
        }
        if (test == 15)
        {
            level1.interactable = true;
            level2.interactable = true;
            level3.interactable = true;
            level4.interactable = true;
            level5.interactable = true;
            level6.interactable = true;
            level7.interactable = true;
            level8.interactable = true;
            level9.interactable = true;
            level10.interactable = true;
            level11.interactable = true;
            level12.interactable = true;
            level13.interactable = true;
            level14.interactable = true;
            level15.interactable = true;
            level16.interactable = true;
            level17.interactable = false;
            level18.interactable = false;
            level19.interactable = false;
            level20.interactable = false;
            bonus.interactable = false;
            about.interactable = true;
        }
        if (test == 16)
        {
            level1.interactable = true;
            level2.interactable = true;
            level3.interactable = true;
            level4.interactable = true;
            level5.interactable = true;
            level6.interactable = true;
            level7.interactable = true;
            level8.interactable = true;
            level9.interactable = true;
            level10.interactable = true;
            level11.interactable = true;
            level12.interactable = true;
            level13.interactable = true;
            level14.interactable = true;
            level15.interactable = true;
            level16.interactable = true;
            level17.interactable = true;
            level18.interactable = false;
            level19.interactable = false;
            level20.interactable = false;
            bonus.interactable = false;
            about.interactable = true;
        }
        if (test == 17)
        {
            level1.interactable = true;
            level2.interactable = true;
            level3.interactable = true;
            level4.interactable = true;
            level5.interactable = true;
            level6.interactable = true;
            level7.interactable = true;
            level8.interactable = true;
            level9.interactable = true;
            level10.interactable = true;
            level11.interactable = true;
            level12.interactable = true;
            level13.interactable = true;
            level14.interactable = true;
            level15.interactable = true;
            level16.interactable = true;
            level17.interactable = true;
            level18.interactable = true;
            level19.interactable = false;
            level20.interactable = false;
            bonus.interactable = false;
            about.interactable = true;
        }
        if (test == 18)
        {
            level1.interactable = true;
            level2.interactable = true;
            level3.interactable = true;
            level4.interactable = true;
            level5.interactable = true;
            level6.interactable = true;
            level7.interactable = true;
            level8.interactable = true;
            level9.interactable = true;
            level10.interactable = true;
            level11.interactable = true;
            level12.interactable = true;
            level13.interactable = true;
            level14.interactable = true;
            level15.interactable = true;
            level16.interactable = true;
            level17.interactable = true;
            level18.interactable = true;
            level19.interactable = true;
            level20.interactable = false;
            bonus.interactable = false;
            about.interactable = true;
        }
        if (test == 19)
        {
            level1.interactable = true;
            level2.interactable = true;
            level3.interactable = true;
            level4.interactable = true;
            level5.interactable = true;
            level6.interactable = true;
            level7.interactable = true;
            level8.interactable = true;
            level9.interactable = true;
            level10.interactable = true;
            level11.interactable = true;
            level12.interactable = true;
            level13.interactable = true;
            level14.interactable = true;
            level15.interactable = true;
            level16.interactable = true;
            level17.interactable = true;
            level18.interactable = true;
            level19.interactable = true;
            level20.interactable = true;
            bonus.interactable = false;
            about.interactable = true;
        }
        if (test == 20)
        {
            level1.interactable = true;
            level2.interactable = true;
            level3.interactable = true;
            level4.interactable = true;
            level5.interactable = true;
            level6.interactable = true;
            level7.interactable = true;
            level8.interactable = true;
            level9.interactable = true;
            level10.interactable = true;
            level11.interactable = true;
            level12.interactable = true;
            level13.interactable = true;
            level14.interactable = true;
            level15.interactable = true;
            level16.interactable = true;
            level17.interactable = true;
            level18.interactable = true;
            level19.interactable = true;
            level20.interactable = true;
            bonus.interactable = true;
            about.interactable = true;
        }
        if (test == 21)
        {
            level1.interactable = true;
            level2.interactable = true;
            level3.interactable = true;
            level4.interactable = true;
            level5.interactable = true;
            level6.interactable = true;
            level7.interactable = true;
            level8.interactable = true;
            level9.interactable = true;
            level10.interactable = true;
            level11.interactable = true;
            level12.interactable = true;
            level13.interactable = true;
            level14.interactable = true;
            level15.interactable = true;
            level16.interactable = true;
            level17.interactable = true;
            level18.interactable = true;
            level19.interactable = true;
            level20.interactable = true;
            bonus.interactable = true;
            about.interactable = true;
        }
    }
}
