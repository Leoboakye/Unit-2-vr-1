using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dmove : MonoBehaviour
{
    Transform sprite;
    Vector2 dmove;

    // Start is called before the first frame update
    void Start()
    {
        sprite = gameObject.transform;
        dmove = new Vector2(-0.01f,-0.01f);
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Vertical");
        sprite.Translate(dmove);
    }
}