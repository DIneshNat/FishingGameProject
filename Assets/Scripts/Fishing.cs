using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Fishing : MonoBehaviour
{
    public MainManager mainManager;
    public bool hasRod;
    public GameObject fishingRod;
    public GameObject hook;
    public FirstPersonController player;
    private bool rodOut;
    private LineRenderer lineRenderer;
    private bool lineout;
    // Update is called once per frame
    private void Start()
    {
        rodOut = false;
        lineout = false;
    }
    private void DestroyRod()
    {
        GameObject.Destroy(GameObject.FindGameObjectWithTag("HeldRod"));
        GameObject.Destroy(GameObject.FindGameObjectWithTag("Hook"));
        GameObject.Destroy(GameObject.FindGameObjectWithTag("Line"));
        lineout = false;
        rodOut = false;
    }
    private void InstantiateRod()
    {
        GameObject.Instantiate(fishingRod, player.transform);
        GameObject.Instantiate(hook, GameObject.FindGameObjectWithTag("Hookspot").transform);
        lineRenderer = GameObject.FindGameObjectWithTag("Line").GetComponent<LineRenderer>();
        lineRenderer.transform.parent = null;
        GameObject.FindGameObjectWithTag("Line").transform.rotation = Quaternion.identity;
        rodOut = true;
        GameObject.FindGameObjectWithTag("Hook").GetComponent<Rigidbody>().isKinematic = true;
        lineRenderer.SetPosition(1, new Vector3(0, 0, 0));
        GameObject.Destroy(GameObject.FindGameObjectWithTag("Hook"));
        GameObject.Instantiate(hook, GameObject.FindGameObjectWithTag("Hookspot").transform);
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && hasRod)
        {
            if (!rodOut)
            {
                InstantiateRod();
            }
            else
            {
                DestroyRod();
            }
        }
        if(Input.GetMouseButtonDown(1) && hasRod && rodOut)
        {
            if (!lineout)
            {
                GameObject.FindGameObjectWithTag("Hook").GetComponent<Rigidbody>().isKinematic = false;
                lineout = true;
                GameObject.FindGameObjectWithTag("Hook").GetComponent<Rigidbody>().useGravity = true;
                GameObject.FindGameObjectWithTag("Hook").transform.parent = null;
                GameObject.FindGameObjectWithTag("Hook").GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * 1200);
            }
            else
            {
                lineout = false;
                lineRenderer.SetPosition(1, new Vector3(0, 0, 0));
                GameObject.Destroy(GameObject.FindGameObjectWithTag("Hook"));
                GameObject.Instantiate(hook, GameObject.FindGameObjectWithTag("Hookspot").transform);
            }
        }
        if(lineout && hasRod && rodOut)
        {
            lineRenderer.transform.parent = null;
            GameObject liney = GameObject.FindGameObjectWithTag("Line");
            GameObject.FindGameObjectWithTag("Line").transform.position = GameObject.FindGameObjectWithTag("Tip").transform.position;
            lineRenderer.SetPosition(1, new Vector3(GameObject.FindGameObjectWithTag("Hook").transform.position.x - liney.transform.position.x, GameObject.FindGameObjectWithTag("Hook").transform.position.y - liney.transform.position.y,GameObject.FindGameObjectWithTag("Hook").transform.position.z - liney.transform.position.z));
        }
    }

}
