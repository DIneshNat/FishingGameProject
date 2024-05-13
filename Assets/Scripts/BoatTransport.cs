using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoatTransport : MonoBehaviour
{
    public FirstPersonController firstPersonController;
    public Sprite crosshairImageMouse;
    public Sprite crosshairImageStandard;
    public float crosshairSizeMouse;
    public float crosshairSizeStandard;
    public MainManager mainManager;
    private void OnMouseDown()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player.transform.position.x > -6 && player.transform.position.x < 4 && player.transform.position.z > 10 && player.transform.position.z < 20 && GameObject.FindGameObjectWithTag("Empty") == null)
        {
            SceneManager.LoadScene("Oceaning");
        }
    }
    private void OnMouseOver()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player.transform.position.x > -6 && player.transform.position.x < 4 && player.transform.position.z > 10 && player.transform.position.z < 20 && GameObject.FindGameObjectWithTag("Empty") == null)
        {
            firstPersonController.crosshairImage = crosshairImageMouse;
            firstPersonController.crosshairSize = crosshairSizeMouse;
        }
        else
        {
            firstPersonController.crosshairImage = crosshairImageStandard;
            firstPersonController.crosshairSize = crosshairSizeStandard;
        }
    }
    private void OnMouseExit()
    {
        firstPersonController.crosshairImage = crosshairImageStandard;
        firstPersonController.crosshairSize = crosshairSizeStandard;
    }
    
}