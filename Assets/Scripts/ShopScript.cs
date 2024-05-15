using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using Unity.VisualScripting;
using System;
using JetBrains.Annotations;

public class ShopScript : MonoBehaviour
{
    public TMP_Text fish;
    public TMP_Text money;
    private MainManager mainManager;
    public GameObject woodappearance;
    public GameObject scoutappearance;
    public GameObject fishappearance;
    public GameObject woodreal;
    public GameObject scoutreal;
    public GameObject fishreal;
    public void QuitShop()
    {
        SceneManager.LoadScene("Beach");
    }

    public void SellFish()
    {
        mainManager = GameObject.FindGameObjectWithTag("Manager").GetComponent<MainManager>();
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
        mainManager.coins = moneyVals;
        mainManager.FishValue = 0;
    }

    public void BuyBoat(int boatVal, GameObject boat, GameObject boatreal)
    {
        mainManager = GameObject.FindGameObjectWithTag("Manager").GetComponent<MainManager>();
        string moneyVal = money.text;
        int moneyVals = Convert.ToInt32(moneyVal);
        if(moneyVals >= boatVal)
        {
            moneyVals -= boatVal;
            money.text = moneyVals.ToString();
            mainManager.boatPretty = boat;
            mainManager.boat = boatreal;
        }
        money.text = moneyVals.ToString();
        mainManager.coins = moneyVals;
    }
    
    public void buyBoat1()
    {
        BuyBoat(2000, woodappearance, woodreal);
    }

    public void buyBoat2()
    {
        BuyBoat(10000, scoutappearance, scoutreal);
    }

    public void buyBoat3()
    {
        BuyBoat(30000, woodappearance, fishreal);
    }
}

