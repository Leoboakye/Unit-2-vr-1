using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keybind : MonoBehaviour
{
    public float speed = 10.0f;
    Transform player;
    Vector2 xmove;
    float xMovement;
    float yMovement;
    // Start is called before the first frame update
    void Start()
    {
        player = gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        xMovement = Input.GetAxis("Horizontal")*speed;
        yMovement = Input.GetAxis("Vertical")*speed;
        xmove = new Vector2(xMovement, yMovement);
        player.Translate(xmove*Time.deltaTime);
        Vector2 flip = new Vector2(-1.0f, 1.0f);
        transform.localScale *= flip;
    }
}
