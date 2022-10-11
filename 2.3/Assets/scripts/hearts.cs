using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hearts : MonoBehaviour
{
    int hearts1 = 100;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         
        Debug.Log(hearts1);
        hearts1 = (hearts1 - 1);
    }
}
