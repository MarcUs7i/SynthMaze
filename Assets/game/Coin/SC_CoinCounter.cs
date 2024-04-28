using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SC_CoinCounter : MonoBehaviour
{
    Text counterText;

    // Start is called before the first frame update
    void Start()
    {
        counterText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //Set the current number of coins to display
        if (counterText.text != SC_2DCoin.totalCoins.ToString())
        {
            if (SC_2DCoin.totalCoins < 10) // If smaller than 10 then print the 0 plus the coins. Example: 09
            {
                counterText.text = "0" + SC_2DCoin.totalCoins.ToString();
            }
            else
            {
                counterText.text = SC_2DCoin.totalCoins.ToString();
            }
        }
    }
}