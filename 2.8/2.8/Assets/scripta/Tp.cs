using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tp : MonoBehaviour
{
   

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("hi");
        if(other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("GS2");
        }
    }
}
