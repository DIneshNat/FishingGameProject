using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using Unity.VisualScripting;
using System;

public class ShopScript : MonoBehaviour
{
    public TMP_Text fish;
    public TMP_Text money;
 
    public void QuitShop()
    {
        SceneManager.LoadScene("Beach");
    }

    public void SellFish()
    {
        string fishVal = fish.text;
        string moneyVal = money.text;
        int fishVals = Convert.ToInt32(fishVal);
        int moneyVals = Convert.ToInt32(moneyVal);
        fish.text = "00000";
        moneyVals += fishVals;
        if (moneyVals > 99999)
        {
            moneyVals = 99999;
        }
        money.text = moneyVals.ToString();
    }

    public void BuyBoat(int boatVal)
    {
        string moneyVal = money.text;
        int moneyVals = Convert.ToInt32(moneyVal);
        if(moneyVals > boatVal)
        {
            moneyVals -= boatVal;
            money.text = moneyVals.ToString();
        }
    }
    
    public void buyBoat1()
    {
        BuyBoat(10000);
    }

    public void buyBoat2()
    {
        BuyBoat(50000);
    }

    public void buyBoat3()
    {
        BuyBoat(75000);
    }
}

