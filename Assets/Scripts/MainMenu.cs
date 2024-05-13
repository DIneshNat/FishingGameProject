using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public MainManager mainmanager;
    public Animator animator;
    public void Update()
    {
        mainmanager = GameObject.FindGameObjectWithTag("Manager").GetComponent<MainManager>();
    }
    public void PlayGame()
    {
        if (mainmanager.ogScene == "nullScene")
        {
            SceneManager.LoadScene("Beach");
        }
        else
        {
            SceneManager.LoadScene(mainmanager.ogScene);
        }
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game is exiting");
    }
}
