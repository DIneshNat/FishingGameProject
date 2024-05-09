using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fishing : MonoBehaviour
{
    public MainManager mainManager;
    public GameObject fishingRod;
    public GameObject hook;
    public FirstPersonController player;
    private bool rodOut;
    private LineRenderer lineRenderer;
    private bool lineout;
    public float xforce;
    public float yforce;
    public float zforce;
    private float timer = 0;
    // Update is called once per frame
    private void Start()
    {
        rodOut = false;
        lineout = false;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && mainManager.hasRod)
        {
            if (!rodOut)
            {
                GameObject.Instantiate(fishingRod, player.transform);
                GameObject.Instantiate(hook, player.transform);
                lineRenderer = GameObject.FindGameObjectWithTag("Line").GetComponent<LineRenderer>();
                rodOut = true;
                GameObject.FindGameObjectWithTag("Hook").GetComponent<Rigidbody>().isKinematic = true;
            }
            else
            {
                GameObject.Destroy(GameObject.FindGameObjectWithTag("HeldRod"));
                GameObject.Destroy(GameObject.FindGameObjectWithTag("Hook"));
                lineout = false;
                rodOut = false;
            }
        }
        if(Input.GetMouseButtonDown(1) && mainManager.hasRod && rodOut && !lineout)
        {
            GameObject.FindGameObjectWithTag("Hook").GetComponent<Rigidbody>().isKinematic = false;
            lineout = true;
            GameObject.FindGameObjectWithTag("Hook").GetComponent<Rigidbody>().useGravity = true;
            GameObject.FindGameObjectWithTag("Hook").GetComponent<Rigidbody>().AddForce(xforce, yforce, zforce, ForceMode.Impulse);
            lineRenderer.positionCount--;
        }
        if(lineout && mainManager.hasRod && rodOut)
        {
            lineRenderer = GameObject.FindGameObjectWithTag("Line").GetComponent<LineRenderer>();
            lineRenderer.SetPosition(2, GameObject.FindGameObjectWithTag("Hook").transform.position);
            timer += Time.deltaTime;
            if(timer > 2)
            {
                lineout = false;
                GameObject.Destroy(GameObject.FindGameObjectWithTag("HeldRod"));
                GameObject.Destroy(GameObject.FindGameObjectWithTag("Hook"));
                GameObject.Instantiate(fishingRod, player.transform);
                GameObject.Instantiate(hook, player.transform);
                GameObject.FindGameObjectWithTag("Hook").GetComponent<Rigidbody>().isKinematic = true;
                lineRenderer = GameObject.FindGameObjectWithTag("Line").GetComponent<LineRenderer>();

                timer = 0;
            }
            Debug.Log(timer);
        }
        if(false)
        {
            if (gameObject.tag == "Sea")
            {
                lineout = false;
                SceneManager.LoadScene("Fish");
            }
            else
            {
                lineout = false;
                GameObject.Destroy(GameObject.FindGameObjectWithTag("HeldRod"));
                GameObject.Destroy(GameObject.FindGameObjectWithTag("Hook"));
                GameObject.Instantiate(fishingRod, player.transform);
                GameObject.Instantiate(hook, player.transform);
            }
        }
    }

}
