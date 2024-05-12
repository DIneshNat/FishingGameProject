using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;

    public GameObject boat;
    public GameObject boatPretty;
    public Vector3 boatpos;
    public bool hasRod = false;
    public Vector3 playerpos;
    public Quaternion playerrot;
    public Quaternion camerarot;
    public bool playedOpening = false;
    public Animator animator;
    public GameObject fishingRod;
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if(scene.name == "Beach")
        {
            GameObject.FindGameObjectWithTag("Player").transform.position = playerpos;
            GameObject.FindGameObjectWithTag("Player").transform.rotation = playerrot;
            GameObject.FindGameObjectWithTag("MainCamera").transform.rotation = camerarot;
            if(!hasRod)
            {
                Debug.Log("rectin rod");
                Instantiate(fishingRod, GameObject.FindGameObjectWithTag("Creator").transform);
            }
        }
    }
    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "Oceaning")
        {
            boatpos = GameObject.FindGameObjectWithTag("Boat").transform.position;
        }
        if(SceneManager.GetActiveScene().name == "Beach")
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<Fishing>().hasRod = hasRod;
            animator = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();
            if (!playedOpening)
            {
                animator.Play("Entrance");
                playedOpening = true;
            }
            playerpos = GameObject.FindGameObjectWithTag("Player").transform.position;
            playerrot = GameObject.FindGameObjectWithTag("Player").transform.rotation;
            camerarot = GameObject.FindGameObjectWithTag("MainCamera").transform.rotation;
        }
    }
}
