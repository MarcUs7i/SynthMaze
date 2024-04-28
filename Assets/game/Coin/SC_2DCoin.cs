using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_2DCoin : MonoBehaviour
{
    //Keep track of total picked coins (Since the value is static, it can be accessed at "SC_2DCoin.totalCoins" from any script)
    public static int totalCoins = 0;
    public static bool IsPlaying = false; 

    //Coin Cooldown
    private bool canPickUp = true;
    public float pickUpCooldown = 0.1f; // Adjust the cooldown duration as needed

    [Header("Animation")]
    public float animDirection = 0; // Coin placement: 0 = Down; 1 = Left; 2 = UP; 3 = Right; Other = Error + Default
    public float animSpeed = 2f; // Animation speed
    public float animCoolDown = 0.5f; // Animation coolDown; After specified time => Animation restarts
    public float animBackInTime = 0.5f; // how much time to get back to previous location
    Vector3 direction;
    int animationEnabled;

    void Awake()
    {
        //Make Collider2D as trigger 
        GetComponent<Collider2D>().isTrigger = true;
        PlayerSaving.LoadingPlayer = true;
        //totalCoins = PlayerSaving.savedCoins;
        if(animDirection is < 0 or > 4)
        {
            Debug.LogError("The animDirection variable is not 0 - 3; Setting to Default");
            animDirection = 0;
        }
        if(animSpeed < 0)
        {
            Debug.LogError("The animSpeed variable is not positive; Setting to Default");
            animSpeed = 2f;
        }
        //Mathf.Round(animDirection, 1);
        //Start Animation at specified direction
        /*if(animDirection == 0) StartCoroutine(CoinAnim(Vector3.down));
        if(animDirection == 1) StartCoroutine(CoinAnim(Vector3.left));
        if(animDirection == 2) StartCoroutine(CoinAnim(Vector3.up));
        if(animDirection == 3) StartCoroutine(CoinAnim(Vector3.right));*/
        if(animDirection == 0) direction = Vector3.down;
        if(animDirection is >0 and <1) direction = Vector3.down + Vector3.left;
        if(animDirection == 1) direction = Vector3.left;
        if(animDirection is >1 and <2) direction = Vector3.left + Vector3.up;
        if(animDirection == 2) direction = Vector3.up;
        if(animDirection is >2 and <3) direction = Vector3.right + Vector3.up;
        if(animDirection == 3) direction = Vector3.right;
        if(animDirection is >3 and <4) direction = Vector3.right + Vector3.down;
        StartCoroutine(CoinAnim());
        
    }

    void OnTriggerEnter2D(Collider2D c2d)
    {
        if (canPickUp && c2d.CompareTag("Player"))
        {
            canPickUp = false; // Disable picking up coins temporarily
            //Add coin to counter
            totalCoins++;
            //Test: Print total number of coins
            Debug.Log("You currently have " + SC_2DCoin.totalCoins + " Coins.");
            IsPlaying = true;
            //Destroy coin
            Destroy(gameObject);
    
            // Start the cooldown coroutine
            StartCoroutine(CoinPickUpCooldown());
        }
    }

    IEnumerator CoinPickUpCooldown()
    {
        yield return new WaitForSeconds(pickUpCooldown);
        canPickUp = true; // Enable coin pickup again after the cooldown
    }

    void Update()
    {
        /*if (totalCoins != PlayerSaving.savedCoins && PlayerSaving.Deleteing == false)
        {
            PlayerSaving.savedCoins = totalCoins;
            PlayerSaving.SavingPlayer = true;
            Debug.Log("Saved " + PlayerSaving.savedCoins);
        }*/
        if(animationEnabled == 1) transform.position -= direction * animSpeed * Time.deltaTime;
        else if(animationEnabled == 2) transform.position += direction * animSpeed * Time.deltaTime;
        
    }

    IEnumerator CoinAnim()
    {
        animationEnabled = 1;
        //transform.position += direction * animSpeed * Time.deltaTime;
        yield return new WaitForSeconds(animBackInTime);
        animationEnabled = 2;
        //transform.position -= direction * animSpeed * Time.deltaTime;
        yield return new WaitForSeconds(animBackInTime);
        animationEnabled = 300;
        yield return new WaitForSeconds(animCoolDown);
        StartCoroutine(CoinAnim());
    }
}