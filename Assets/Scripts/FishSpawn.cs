using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawn : MonoBehaviour
{
    public GameObject Fish;
    public GameObject Fish2;
    public GameObject Fish3;
    public Transform fishy;
    public float spawnRate = 100;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Fish3, new Vector3(Random.Range(-439, 949), Random.Range(10, 320), 0), transform.rotation, fishy);
        Instantiate(Fish3, new Vector3(Random.Range(-439, 949), Random.Range(10, 320), 0), transform.rotation, fishy);
        Instantiate(Fish3, new Vector3(Random.Range(-439, 949), Random.Range(10, 320), 0), transform.rotation, fishy);
        Instantiate(Fish3, new Vector3(Random.Range(-439, 949), Random.Range(10, 320), 0), transform.rotation, fishy);
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnFish();
            timer = 0;
        }
    }

    void spawnFish()
    {
        Instantiate(Fish3, new Vector3(transform.position.x, Random.Range(10, 320), 0), transform.rotation, fishy);
    }
}
