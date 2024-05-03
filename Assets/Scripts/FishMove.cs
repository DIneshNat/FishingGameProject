using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using System;


public class FishMove : MonoBehaviour
{
    public float moveSpeed = 5;
    public float fishType = 1;
    public TMP_Text money;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(fishType == 1)
        {
            transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        }
        else
        {
            transform.position = transform.position - (Vector3.left * moveSpeed) * Time.deltaTime;
        }

        if(transform.position.x < -440 || transform.position.x > 950)
        {
            Destroy(gameObject);
        }
    }
    public void destroyFish()
    {
        Destroy(gameObject);

    }
}
