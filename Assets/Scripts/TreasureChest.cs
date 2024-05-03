using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TreasureChest : MonoBehaviour
{
    public FirstPersonController firstPersonController;
    public Sprite crosshairImageMouse;
    public Sprite crosshairImageStandard;
    public float crosshairSizeMouse;
    public float crosshairSizeStandard;
    private void OnMouseDown()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player.transform.position.x > -10 && player.transform.position.x < 0 && player.transform.position.z > -4 && player.transform.position.z < 4)
        {
            SceneManager.LoadScene("Shop");
        }
    }
    private void OnMouseOver()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player.transform.position.x > -10 && player.transform.position.x < 0 && player.transform.position.z > -4 && player.transform.position.z < 4)
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
        SceneManager.LoadScene("Shop");
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        firstPersonController.crosshairImage = crosshairImageStandard;
        firstPersonController.crosshairSize = crosshairSizeStandard;
    }
}
