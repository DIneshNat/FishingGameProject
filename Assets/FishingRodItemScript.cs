using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FishingRodItemScript : MonoBehaviour
{
    public FirstPersonController firstPersonController;
    public Sprite crosshairImageMouse;
    public Sprite crosshairImageStandard;
    public float crosshairSizeMouse;
    public float crosshairSizeStandard;
    public MainManager manager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseEnter()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player.transform.position.x > -5 && player.transform.position.x < 4 && player.transform.position.z > -2 && player.transform.position.z < 7)
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

    private void OnMouseDown()
    {
        manager.hasRod = true;
        firstPersonController.crosshairImage = crosshairImageStandard;
        firstPersonController.crosshairSize = crosshairSizeStandard;
        Destroy(GameObject.FindGameObjectWithTag("FishinRod"));
    }
}
