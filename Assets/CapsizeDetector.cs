using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CapsizeDetector : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        GameObject boat = GameObject.FindGameObjectWithTag("Boat");
        if (boat.transform.rotation.x > 90 || boat.transform.rotation.x < -90 || boat.transform.rotation.z > 90 || boat.transform.rotation.z < -90 || boat.transform.position.y < -5)
        {
            SceneManager.LoadScene("Beach");
        }
    }
}
