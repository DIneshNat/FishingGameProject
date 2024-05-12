using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrettyBoatSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public FirstPersonController firstPersonController;
    void Start()
    {
        Instantiate(MainManager.Instance.boatPretty);
    }
}
