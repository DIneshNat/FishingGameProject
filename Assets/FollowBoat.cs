using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBoat : MonoBehaviour
{
    public int displacex, displacey, displacez;
    public int rotatew, rotatex, rotatey, rotatez;
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        player = GameObject.FindGameObjectWithTag("CamMount");
        transform.position = new Vector3(player.transform.position.x + displacex, player.transform.position.y + displacey, player.transform.position.z + displacez);
        transform.rotation = new Quaternion(this.transform.rotation.x, this.transform.rotation.y, player.transform.rotation.z +rotatez , player.transform.rotation.w + rotatew);
    }
}
