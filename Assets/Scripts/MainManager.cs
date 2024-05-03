using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;

    public GameObject boat;
    public GameObject boatPretty;
    public Vector3 boatpos;
    
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    private void Update()
    {
        boatpos = GameObject.FindGameObjectWithTag("Boat").transform.position;
    }
}
