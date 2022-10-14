using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hearts : MonoBehaviour
{
    int hearts1 = 100;

        Rigidbody2D player = null;
    
        // Start is called before the first frame update
    void Start()
    {
        Debug.Log(hearts1);

        Debug.Log(player);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(hearts1);

        Debug.Log(player);
    }
}
