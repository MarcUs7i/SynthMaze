/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public float gravity = 100f;
    private Rigidbody2D rb2d;
    public Transform PlayerTransform;
    public GameObject objPlayer;
    public int playerCounter = 2;
    bool IsPauseing = false;
    //bool moveLeft;
	//bool moveRight;

    float horizontalInput;
    float verticalInput;
    bool RunningAnimation = false;
    public GameObject RunAnim;
    public static float touched = 0;
    public static bool StopMoving = false;

    void Start()
    {
        touched = 0;
        RunningAnimation = false;
        rb2d = GetComponent<Rigidbody2D>();
        StopMoving = false;
        PlayerDown();
    }

    void OnCollisionEnter2D(Collision2D c2d)
    {
        if (c2d.gameObject.CompareTag("Ground"))
        {
            touched++;
            //Debug.Log("Touched: " + touched);
            RunningAnimation = false;
        }
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        
		IsPauseing = Pause.IsPause;

		if (IsPauseing == false && PlayerMove.currentPlayerCount == playerCounter)
		{
            if (RunningAnimation)
            {
                Instantiate(RunAnim, PlayerTransform.position, PlayerTransform.rotation);
            }

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
	

            /*if(rb2d.velocity == Vector2.zero && CameraController.CameraPlayer == true && StopMoving == false)// Remove for Backup
            {
                if(verticalInput > 0)
                {
                    RunningAnimation = true;
                    PlayerUP();
                }

                else if(verticalInput < 0)
                {
                    RunningAnimation = true;
                    PlayerDown();
                }

                else if(horizontalInput < 0)
                {
                    RunningAnimation = true;
                    PlayerLeft();
                }

                else if(horizontalInput > 0)
                {
                    RunningAnimation = true;
                    PlayerRight();
                }
            }

            if (RunningAnimation)
            {
                //Debug.Log("Running");
                Instantiate(RunAnim, PlayerTransform.position, PlayerTransform.rotation);
                Instantiate(RunAnim, PlayerTransform.position, PlayerTransform.rotation);
                Instantiate(RunAnim, PlayerTransform.position, PlayerTransform.rotation);
                Instantiate(RunAnim, PlayerTransform.position, PlayerTransform.rotation);
            }

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

    /*public void PlayerUP()// Remove for Backup
    {
        if(rb2d.velocity == Vector2.zero && CameraController.CameraPlayer == true && StopMoving == false)
        {
            Physics2D.gravity = Vector2.up * gravity;
    
            rb2d.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
            PlayerTransform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }

    public void PlayerDown()
    {
        if(rb2d.velocity == Vector2.zero && CameraController.CameraPlayer == true && StopMoving == false)
        {
            Physics2D.gravity = Vector2.down * gravity;
    
            rb2d.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
            PlayerTransform.rotation = Quaternion.Euler(0, 0, 180);
        }
    }

    public void PlayerLeft()
    {
        if(rb2d.velocity == Vector2.zero && CameraController.CameraPlayer == true && StopMoving == false)
        {
            Physics2D.gravity = Vector2.left * gravity;
    
            rb2d.constraints = RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;

            PlayerTransform.rotation = Quaternion.Euler(0, 0, 90);
        }
    }

    public void PlayerRight()
    {
        if(rb2d.velocity == Vector2.zero && CameraController.CameraPlayer == true && StopMoving == false)
        {
            Physics2D.gravity = Vector2.right * gravity;
    
            rb2d.constraints = RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;

            PlayerTransform.rotation = Quaternion.Euler(0, 0, 270);
        }
    }
}
*/