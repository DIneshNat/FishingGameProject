using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;

    public GameObject boat;
    public GameObject boatPretty;
    public Vector3 boatpos;
    public bool hasRod = false;
    public bool rodOut = false;
    public Vector3 playerpos;
    public Quaternion playerrot;
    public Quaternion camerarot;
    public bool playedOpening = false;
    public Animator animator;
    public GameObject fishingRod;
    public string ogScene;
    public string ogFishScene;
    private bool setScene = false;
    public int FishValue = 0;
    public int coins = 0;
    private void Awake()
    {
        if(!setScene)
        {
            ogScene = "nullScene";
            setScene = true;
        }
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
                Instantiate(fishingRod, GameObject.FindGameObjectWithTag("Creator").transform);
            }
            GameObject.FindGameObjectWithTag("Player").GetComponent<Fishing>().rodOut = rodOut;
            if(rodOut)
            {
                GameObject.FindGameObjectWithTag("Player").GetComponent<Fishing>().InstantiateRod();
            }
        }
        if(scene.name == "Fish")
        {
            GameObject.FindGameObjectWithTag("FishScore").GetComponent<TMPro.TMP_Text>().text = FishValue.ToString();
        }
        if(scene.name == "Shop")
        {
            GameObject.FindGameObjectWithTag("FishScore").GetComponent<TMPro.TMP_Text>().text = FishValue.ToString();
            GameObject.FindGameObjectWithTag("Money").GetComponent<TMPro.TMP_Text>().text = coins.ToString();
        }
    }
    
    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "Oceaning")
        {
            boatpos = GameObject.FindGameObjectWithTag("Boat").transform.position;
            GameObject.FindGameObjectWithTag("Player").GetComponent<Fishing>().hasRod = hasRod;
            rodOut = GameObject.FindGameObjectWithTag("Player").GetComponent<Fishing>().rodOut;
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
            rodOut = GameObject.FindGameObjectWithTag("Player").GetComponent<Fishing>().rodOut;
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(SceneManager.GetActiveScene() != SceneManager.GetSceneByName("HomeScreen"))
            {
                Cursor.lockState = CursorLockMode.None;
                ogScene = SceneManager.GetActiveScene().name;
                SceneManager.LoadScene("HomeScreen");
            }
        }
        if(SceneManager.GetActiveScene().name == "Fish"){
            FishValue = Convert.ToInt32(GameObject.FindGameObjectWithTag("FishScore").GetComponent<TMPro.TMP_Text>().text);
        }
    }
}
