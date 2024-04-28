/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //This program is more to pass variables to other scripts than managing players
    public float gravity = 100f;
    [Header("Transform")]
    public Transform Player1Transform;
    public Transform Player2Transform;
    private Transform currentPlayerTransform;
    [Header("GameObjects")]
    //public GameObject c;
    private GameObject objCurrentPlayer;
    public GameObject objPlayer1;
    public GameObject objPlayer2;
    [Header("If two players")]
    public bool twoPlayer = false;
    public static bool hasTwoPlayer = false;
    [Header("Animators")]
	//public Animator animator;
    public Animator player1Animator;
    public Animator player2Animator;
    private Animator currentPlayerAnimator;
    public static bool stopAnimator = false;
    public static bool switchPlayers = false;
    bool IsPauseing = false;
	bool IsPlay = false;
    //bool moveLeft;
	//bool moveRight;
    public AudioSource audioSource;

    float horizontalInput;
    float verticalInput;
    public static bool RunningAnimation = false;
    public GameObject RunAnim;
    public static float touched = 0;
    public static int currentPlayerCount;
    bool alreadyChangedPlayerAtEnd = false;
    public static bool StopMoving = false;


    //To delete the Players
    public static int deletePlayer = 0;

    void Start()
    {
        hasTwoPlayer = twoPlayer;

        touched = 0;
        RunningAnimation = false;
        alreadyChangedPlayerAtEnd = false;

        objPlayer2.SetActive(twoPlayer);

        currentPlayerCount = 1;
        objCurrentPlayer = objPlayer1;
        currentPlayerAnimator = player1Animator;
        currentPlayerAnimator.SetBool("Stop", false);
    }


    void Update()
    {   
		IsPlay = SC_2DCoin.IsPlaying;
		IsPauseing = Pause.IsPause;

		if (IsPlay == true)
		{
			audioSource.Play();
			SC_2DCoin.IsPlaying = false;
		}

		if (IsPauseing == false)
		{
			//UI buttons
			/*if (moveLeft)
			{
				horizontalMove = -40f;
			}
			if (moveRight)
			{
				horizontalMove = 40f;
			}
			else if (!moveLeft && !moveRight)
			{
				horizontalMove = 0f;
			}
			if (horizontalMove == 0f)
			{
				horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
			}*/
		/*} // Remove for backup
        
        //Automatically switch players after first one entered the end.
        /*if(LevelMgr.steps == 2 && alreadyChangedPlayerAtEnd == false)
        {
            alreadyChangedPlayerAtEnd = true;
            SwitchPlayer();
        }*/

        //Sets "Stop" to currently selected player's Animator
        /*if (stopAnimator) // Remove /* for backup
        {
            stopAnimator = false;
            currentPlayerAnimator.SetBool("Stop", true);
        }
        //Switch Players in code
        if(switchPlayers)
        {
            switchPlayers = !switchPlayers;
            SwitchPlayer();
        }

        //Switch Players
        if (Input.GetKeyDown(KeyCode.V))
        {
            SwitchPlayer();
        }

        //Pass StopMoving to currently selected players
        if (currentPlayerCount == 1) Player1.StopMoving = StopMoving;
        else if (currentPlayerCount == 2) Player2.StopMoving = StopMoving;

        //To delete Players
        if(deletePlayer == 1 && objPlayer1 != null)
        {
            objPlayer1.SetActive(false);
        }
        else if(deletePlayer == 2 && objPlayer2 != null)
        {
            objPlayer2.SetActive(false);
        }
        else if(deletePlayer == 3 && objCurrentPlayer != null)
        {
            objCurrentPlayer.SetActive(false);
        }
        else
        {
            deletePlayer = 0;
        }

	}

	/*public void PointerDownLeft()
	{
		moveLeft = true;
	}

	public void PointerUpLeft()
	{
		moveLeft = false;
	}

	public void PointerDownRight()
	{
		moveRight = true;
	}

	public void PointerUpRight()
	{
		moveRight = false;
	}*/

    /*void SwitchPlayer() // Remove /* for Backup
    {
        if(currentPlayerCount == 1 && CameraController.CameraPlayer == true && twoPlayer)
        {
            currentPlayerCount = 2;
            currentPlayerTransform = Player2Transform;
            objCurrentPlayer = objPlayer2;
            currentPlayerAnimator = player2Animator;
            Debug.Log("Switched to Player 2");
        }
        else if(currentPlayerCount == 2 && CameraController.CameraPlayer == true && twoPlayer)
        {
            currentPlayerCount = 1;
            currentPlayerTransform = Player1Transform;
            objCurrentPlayer = objPlayer1;
            currentPlayerAnimator = player1Animator;
            Debug.Log("Switched to Player 1");
        }
    }

}


*/ // Remove for Backup