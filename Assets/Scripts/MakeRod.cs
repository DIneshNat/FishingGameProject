using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeRod : MonoBehaviour
{
    public MainManager mainManager;
    public GameObject fishingRod;
    public TMPro.TMP_Text rodinfo;
    // Start is called before the first frame update
    void Awake()
    {
        if(!mainManager.hasRod)
        {
            Debug.Log("Player has no rod on scene load");
            Instantiate(fishingRod, this.transform);
        }
        else
        {
            Debug.Log("Player has rod on scene load");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
