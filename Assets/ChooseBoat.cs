using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ChooseBoat : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(MainManager.Instance.boat, this.transform);
    }
    private void Update()
    {
        /**
        if(GameObject.FindGameObjectWithTag("Boat").transform.position.y < 0)
        {
            GameObject.FindGameObjectWithTag("Boat").transform.position = new Vector3(GameObject.FindGameObjectWithTag("Boat").transform.position.x, 0, GameObject.FindGameObjectWithTag("Boat").transform.position.z);
        }
        if(GameObject.FindGameObjectWithTag("Boat").transform.rotation.x < -.45)
        {
            GameObject.FindGameObjectWithTag("Boat").transform.rotation = new Quaternion(GameObject.FindGameObjectWithTag("Boat").transform.rotation.w, -.45f, GameObject.FindGameObjectWithTag("Boat").transform.position.y, GameObject.FindGameObjectWithTag("Boat").transform.position.z);
        }
        if(GameObject.FindGameObjectWithTag("Boat").transform.rotation.x > .45)
        {
            GameObject.FindGameObjectWithTag("Boat").transform.rotation = new Quaternion(GameObject.FindGameObjectWithTag("Boat").transform.rotation.w, .45f, GameObject.FindGameObjectWithTag("Boat").transform.position.y, GameObject.FindGameObjectWithTag("Boat").transform.position.z);
        }
        if (GameObject.FindGameObjectWithTag("Boat").transform.rotation.z > .45)
        {
            GameObject.FindGameObjectWithTag("Boat").transform.rotation = new Quaternion(GameObject.FindGameObjectWithTag("Boat").transform.rotation.w, GameObject.FindGameObjectWithTag("Boat").transform.rotation.x, GameObject.FindGameObjectWithTag("Boat").transform.position.y, .45f);

        }
        if (GameObject.FindGameObjectWithTag("Boat").transform.rotation.z < -.45)
        {
            GameObject.FindGameObjectWithTag("Boat").transform.rotation = new Quaternion(GameObject.FindGameObjectWithTag("Boat").transform.rotation.w, GameObject.FindGameObjectWithTag("Boat").transform.rotation.x, GameObject.FindGameObjectWithTag("Boat").transform.position.y, -.45f);

        }
        **/
    }
}
