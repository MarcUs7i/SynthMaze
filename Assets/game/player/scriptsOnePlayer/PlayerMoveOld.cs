using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveOld : MonoBehaviour
{

    public float gravity = 100f;
    private Rigidbody2D rb2d;
    public Transform Player1;
    public Transform Player2;
    public GameObject c;
	public Animator animator;
    bool IsPauseing = false;
	bool IsPlay = false;
    //bool moveLeft;
	//bool moveRight;
    public AudioSource audioSource;

    float horizontalInput;
    float verticalInput;
    bool RunningAnimation = false;
    public GameObject RunAnim;
    float touched = 0;
    public static bool StopMoving = false;

    void Start()
    {
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
        
		IsPlay = SC_2DCoin.IsPlaying;
		IsPauseing = Pause.IsPause;

		if (IsPlay == true)
		{
			audioSource.Play();
			SC_2DCoin.IsPlaying = false;
		}

		if (IsPauseing == false)
		{
            if (RunningAnimation)
            {
                Instantiate(RunAnim, transform.position, transform.rotation);
            }
			//Debug.Log(horizontalMove);

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
	
			//animator.SetFloat("Speed", Mathf.Abs(horizontalMove));


			if (Enemy.TakedDamage == true)
			{
				//jump = true;
				animator.SetBool("IsJumping", true);
			}

            if(rb2d.velocity == Vector2.zero && CameraController.CameraPlayer == true && StopMoving == false)
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
                Instantiate(RunAnim, Player1.position, Player1.rotation);
                Instantiate(RunAnim, Player1.position, Player1.rotation);
                Instantiate(RunAnim, Player1.position, Player1.rotation);
                Instantiate(RunAnim, Player1.position, Player1.rotation);
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

    public void PlayerUP()
    {
        if(rb2d.velocity == Vector2.zero && CameraController.CameraPlayer == true && StopMoving == false)
        {
            Physics2D.gravity = Vector2.up * gravity;
    
            rb2d.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
            Player1.rotation = Quaternion.Euler(0, 0, 0);
            /*if (c.Player1.localRotation.eulerAngles.z == 0)
            {
                Player1.Rotate(0f, 0f, 0f);
            }
            else if (c.Player1.localRotation.eulerAngles.z == 90)
            {
                Player1.Rotate(0f, 0f, -90f);
            }
            else if (c.Player1.localRotation.eulerAngles.z == 180)
            {
                Player1.Rotate(0f, 0f, -180f);
            }
            else if (c.Player1.localRotation.eulerAngles.z == -90)
            {
                Player1.Rotate(0f, 0f, 90f);
            }*/
            /*Quaternion newRotation = Quaternion.Euler(0f, 0f, 90f); // Rotate 90 degrees around the Y-axis
            gameObject.Player1.rotation = newRotation;*/
        }
    }

    public void PlayerDown()
    {
        if(rb2d.velocity == Vector2.zero && CameraController.CameraPlayer == true && StopMoving == false)
        {
            Physics2D.gravity = Vector2.down * gravity;
    
            rb2d.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;

            /*if (c.Player1.localRotation.eulerAngles.z == 0)
            {
                Player1.Rotate(0f, 0f, 180f);
            }
            else if (c.Player1.localRotation.eulerAngles.z == 90)
            {
                Player1.Rotate(0f, 0f, 90f);
            }
            else if (c.Player1.localRotation.eulerAngles.z == 180)
            {
                Player1.Rotate(0f, 0f, 0f);
            }
            else if (c.Player1.localRotation.eulerAngles.z == -90)
            {
                Player1.Rotate(0f, 0f, 270f);
            }*/
            Player1.rotation = Quaternion.Euler(0, 0, 180);
        }
    }

    public void PlayerLeft()
    {
        if(rb2d.velocity == Vector2.zero && CameraController.CameraPlayer == true && StopMoving == false)
        {
            Physics2D.gravity = Vector2.left * gravity;
    
            rb2d.constraints = RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;

            /*if (c.Player1.localRotation.eulerAngles.z == 0)
            {
                Player1.Rotate(0f, 0f, 90f);
            }
            else if (c.Player1.localRotation.eulerAngles.z == 90)
            {
                Player1.Rotate(0f, 0f, 0f);
            }
            else if (c.Player1.localRotation.eulerAngles.z == 180)
            {
                Player1.Rotate(0f, 0f, -90f);
            }
            else if (c.Player1.localRotation.eulerAngles.z == -90)
            {
                Player1.Rotate(0f, 0f, 180f);
            }*/
            Player1.rotation = Quaternion.Euler(0, 0, 90);
        }
    }

    public void PlayerRight()
    {
        if(rb2d.velocity == Vector2.zero && CameraController.CameraPlayer == true && StopMoving == false)
        {
            Physics2D.gravity = Vector2.right * gravity;
    
            rb2d.constraints = RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;

            /*if (c.Player1.localRotation.eulerAngles.z == 0)
            {
                Player1.Rotate(0f, 0f, -90f);
            }
            else if (c.Player1.localRotation.eulerAngles.z == 90)
            {
                Player1.Rotate(0f, 0f, -180f);
            }
            else if (c.Player1.localRotation.eulerAngles.z == 180)
            {
                Player1.Rotate(0f, 0f, -270f);
            }
            else if (c.Player1.localRotation.eulerAngles.z == -90)
            {
                Player1.Rotate(0f, 0f, 0f);
            }*/
            Player1.rotation = Quaternion.Euler(0, 0, 270);
        }
    }

}


