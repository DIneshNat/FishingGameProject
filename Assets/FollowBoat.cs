using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        transform.position = new Vector3(player.transform.position.x + displacex, player.transform.position.y + displacey, player.transform.position.z + displacez);
        transform.rotation = new Quaternion(player.transform.rotation.x + rotatex, player.transform.rotation.y + rotatey, player.transform.rotation.z +rotatez , player.transform.rotation.w + rotatew);
    }
}
