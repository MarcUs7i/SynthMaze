/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraController : MonoBehaviour
{
    public CinemachineVirtualCameraBase camera1; // Reference to the first VCam
    public CinemachineVirtualCameraBase camera2; // Reference to the second VCam
    public Animator cameraButtonAnimator;
    public float cameraButtonSwitch = 1f;
    public static bool CameraPlayer = true;
    public Transform player1;
    public Transform player2;
    public GameObject triangle;
    float horizontalInput;
    float verticalInput;
    public float speed = 5.0f;
    public float maxUpY = 30f;
    public float maxDownY = -30f;
    public float range = 3f;
    public float range2 = 5f;
    public float backSpeed = 2.0f;
    bool BackToPlayer = false;
    public float yOfCamera = 0;
    bool playerFirstMoved = false;
    int currentPlayerCountOfPlayerMove;
    

    // Start is called before the first frame update
    void Start()
    {
        CameraPlayer = true;
        /*Vector3 newCamPosition = transform.position;
        newCamPosition.y = yOfCamera;*/
        /*playerFirstMoved = false;//Remove comment for Backup
        triangle.SetActive(false);
        cameraButtonAnimator.SetBool("CameraControlButtonPressed", false);
    }

    // Update is called once per frame
    void Update()
    {
        currentPlayerCountOfPlayerMove = PlayerMove.currentPlayerCount;
        if (Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0)
        {
            playerFirstMoved = true;
        }
        float distance = Mathf.Abs(transform.position.y - player1.position.y);
        if(currentPlayerCountOfPlayerMove == 1) distance = Mathf.Abs(transform.position.y - player1.position.y);
        if(currentPlayerCountOfPlayerMove == 2) distance = Mathf.Abs(transform.position.y - player2.position.y);

        if (CameraPlayer && BackToPlayer && distance > range && currentPlayerCountOfPlayerMove == 1)
        {
            float newYPosition = Mathf.MoveTowards(transform.position.y, player1.position.y, speed * Time.deltaTime);
            newYPosition = Mathf.Clamp(newYPosition, player1.position.y + maxDownY, player1.position.y + maxUpY);

            transform.position = new Vector3(transform.position.x, newYPosition, transform.position.z);
        }
        else if (CameraPlayer && BackToPlayer && distance > range && currentPlayerCountOfPlayerMove == 2)
        {
            float newYPosition = Mathf.MoveTowards(transform.position.y, player2.position.y, speed * Time.deltaTime);
            newYPosition = Mathf.Clamp(newYPosition, player2.position.y + maxDownY, player2.position.y + maxUpY);

            transform.position = new Vector3(transform.position.x, newYPosition, transform.position.z);
        }


        if (distance <= range || ((transform.position.y == player1.position.y && currentPlayerCountOfPlayerMove == 1) || (transform.position.y == player2.position.y && currentPlayerCountOfPlayerMove == 2)))
        {
            BackToPlayer = false;
        }
        if (CameraPlayer && !Pause.IsPause && !BackToPlayer && playerFirstMoved)
        {
            Vector3 newCamPosition = transform.position;
            newCamPosition.y = player1.position.y;
            if(currentPlayerCountOfPlayerMove == 1) newCamPosition.y = player1.position.y;
            if(currentPlayerCountOfPlayerMove == 2) newCamPosition.y = player2.position.y;
            transform.position = newCamPosition;
            camera1.Priority = 10;  // Set the priority higher to activate this camera
            camera2.Priority = 0;   // Set the priority lower to deactivate the other camera
            triangle.SetActive(false);
        }

        //horizontalInput = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.C))
        {
            CameraPressed();
        }
        
        if (!CameraPlayer && !Pause.IsPause)
        {
            verticalInput = Input.GetAxis("Vertical");
            camera1.Priority = 0;   // Set the priority lower to deactivate the first camera
            camera2.Priority = 10;  // Set the priority higher to activate this camera
            triangle.SetActive(true);

            if (verticalInput < 0 && transform.position.y >= maxDownY)
            {
                transform.position += Vector3.down * speed * Time.deltaTime;
            }
            else if (verticalInput > 0 && transform.position.y <= maxUpY)
            {
                transform.position += Vector3.up * speed * Time.deltaTime;
            }


        }
        if(LevelMgr.BackToMain)
        {
            Vector3 newCamPosition = transform.position;
            newCamPosition.y = yOfCamera;
        }
    }
    public void CameraPressed()
    {
        playerFirstMoved = true;
        StartCoroutine(cameraButtonPressedAnimation());
        if(CameraPlayer)
        {
            CameraPlayer = false;
            Debug.Log("Camera Mode");
        }
        else if(!CameraPlayer)
        {
            CameraPlayer = true;
            Debug.Log("Player Mode");
            BackToPlayer = true;
        }
    }

    IEnumerator cameraButtonPressedAnimation()
    {
        cameraButtonAnimator.SetBool("CameraControlButtonPressed", true);
        yield return new WaitForSeconds(cameraButtonSwitch);
        cameraButtonAnimator.SetBool("CameraControlButtonPressed", false);
    }
}
*/