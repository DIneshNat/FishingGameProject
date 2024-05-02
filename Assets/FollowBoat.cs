using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Unity.VisualScripting;

public class FollowBoat : MonoBehaviour
{
    public int displacex, displacey, displacez;
    public int rotatew, rotatex, rotatey, rotatez;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Boat"); // The player
    }

    // Update is called once per frame
    void Update()
    {
        
        player = GameObject.FindGameObjectWithTag("Boat");
        transform.position = new Vector3((float)(player.transform.position.x + (displacex * Math.Cos(Math.PI * player.transform.rotation.y))), 5, (float)(player.transform.position.z - (displacez * Math.Sin(Math.PI * player.transform.rotation.z))));
        transform.rotation = new Quaternion(0, player.transform.rotation.y + rotatey, player.transform.rotation.z +rotatez , player.transform.rotation.w + rotatew);
    }
}
