using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterFishing : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Sea")
        {
            GameObject.FindGameObjectWithTag("Manager").GetComponent<MainManager>().ogFishScene = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene("Fish");
            Cursor.lockState = CursorLockMode.None;
        }
    }
    private void Update()
    {
        if(SceneManager.GetActiveScene().name == "Oceaning" && this.transform.position.y < -2)
        {
            GameObject.FindGameObjectWithTag("Manager").GetComponent<MainManager>().ogFishScene = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene("Fish");
            Cursor.lockState = CursorLockMode.None;
        }    
    }
}
