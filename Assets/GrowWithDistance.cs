using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowWithDistance : MonoBehaviour
{
    // Update is called once per frame

    void Update()
    {
        Vector3 place = GameObject.FindGameObjectWithTag("Boat").transform.position;
        Vector3 zone = transform.position;
        if(place.x >= zone.x + 450 || place.x <= zone.x - 450 || place.z >= zone.z + 450 || place.z <= zone.z -450)
        {
            transform.position = place;
        }
    }
}
