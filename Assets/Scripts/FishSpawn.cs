using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FishSpawn : MonoBehaviour
{
    public GameObject Fish;
    public GameObject Fish2;
    public GameObject Fish3;
    public Transform fishy;
    public float spawnRate = 100;
    private float timer = 0;
    private MainManager manager;
    private Vector3 distance;
    private float distanceTotal;
    // Start is called before the first frame update
    void Start()
    {
        if(distanceTotal > 1000)
        {
            Instantiate(Fish3, new Vector3(Random.Range(-439, 949), Random.Range(10, 320), 0), transform.rotation, fishy);
            Instantiate(Fish3, new Vector3(Random.Range(-439, 949), Random.Range(10, 320), 0), transform.rotation, fishy);
            Instantiate(Fish3, new Vector3(Random.Range(-439, 949), Random.Range(10, 320), 0), transform.rotation, fishy);
            Instantiate(Fish3, new Vector3(Random.Range(-439, 949), Random.Range(10, 320), 0), transform.rotation, fishy);
        }
        else if (distanceTotal > 500)
        {
            Instantiate(Fish2, new Vector3(Random.Range(-439, 949), Random.Range(10, 320), 0), transform.rotation, fishy);
            Instantiate(Fish2, new Vector3(Random.Range(-439, 949), Random.Range(10, 320), 0), transform.rotation, fishy);
            Instantiate(Fish2, new Vector3(Random.Range(-439, 949), Random.Range(10, 320), 0), transform.rotation, fishy);
            Instantiate(Fish2, new Vector3(Random.Range(-439, 949), Random.Range(10, 320), 0), transform.rotation, fishy);
        }
        else
        {
            Instantiate(Fish, new Vector3(Random.Range(-439, 949), Random.Range(10, 320), 0), transform.rotation, fishy);
            Instantiate(Fish, new Vector3(Random.Range(-439, 949), Random.Range(10, 320), 0), transform.rotation, fishy);
            Instantiate(Fish, new Vector3(Random.Range(-439, 949), Random.Range(10, 320), 0), transform.rotation, fishy);
            Instantiate(Fish, new Vector3(Random.Range(-439, 949), Random.Range(10, 320), 0), transform.rotation, fishy);
        }
    }

    // Update is called once per frame
    void Update()
    {
        manager = GameObject.FindGameObjectWithTag("Manager").GetComponent<MainManager>();
        distance = manager.boatpos;
        distanceTotal = distance.x + distance.y + distance.z;


        if(timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnFish();
            timer = 0;
        }
        if (Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene("Beach");
        }
    }

    void spawnFish()
    {
        if (distanceTotal > 1000)
        {
            Instantiate(Fish3, new Vector3(transform.position.x, Random.Range(10, 320), 0), transform.rotation, fishy);
        }
        else if (distanceTotal > 500)
        {
            Instantiate(Fish2, new Vector3(transform.position.x, Random.Range(10, 320), 0), transform.rotation, fishy);
        }
        else
        {
            Instantiate(Fish, new Vector3(transform.position.x, Random.Range(10, 320), 0), transform.rotation, fishy);
        }
    }
}
