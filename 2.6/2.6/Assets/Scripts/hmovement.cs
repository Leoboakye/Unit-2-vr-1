using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hmovement : MonoBehaviour
{
    Transform sprite;
    Vector2 xmove;
    // Start is called before the first frame update
    void Start()
    {
        sprite = gameObject.transform;
        xmove = new Vector2(-1.0f,0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        sprite.Translate(xmove * Time.deltaTime);
    }
}
