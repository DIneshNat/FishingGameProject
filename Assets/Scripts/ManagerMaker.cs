using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerMaker : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject manager;
    // Start is called before the first frame update
    private void Awake()
    {
        if (GameObject.FindGameObjectWithTag("Manager") == null)
        {
            Instantiate(manager);
        }
    }
}
