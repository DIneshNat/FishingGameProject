using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OceanPower : MonoBehaviour
{
    MainManager mainManager;
    GameObject boat;
    // Start is called before the first frame update
    void Start()
    {
        mainManager = GameObject.FindGameObjectWithTag("Manager").GetComponent<MainManager>();

        this.GetComponent<Fishing>().rodOut = mainManager.rodOut;
        if (mainManager.rodOut)
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<Fishing>().InstantiateRod();
        }
        boat = GameObject.FindGameObjectWithTag("Boat");
        boat.transform.position = mainManager.boatpos;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
