using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vmove : MonoBehaviour
{
    Vector2 ymove;
    Transform sprite;
    // Start is called before the first frame update
    void Start()
    {
        sprite = gameObject.transform;
        ymove = new Vector2(0.0f,0.01f);
    }

    // Update is called once per frame
    void Update()
    {
        float y = Input.GetAxis("Vertical");
        sprite.Translate(ymove);
    }
}
