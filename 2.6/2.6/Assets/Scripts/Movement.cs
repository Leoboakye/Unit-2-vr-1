using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Vector2 Xmove;
    Transform Player;
    // Start is called before the first frame update
    void Start()
    {
         Xmove = new Vector2(1.0f,0.0f);

        Player = gameObject.transform;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Xmove* Time.deltaTime);
    }
}
