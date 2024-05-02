using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ChooseBoat : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(MainManager.Instance.boat);
    }
}
