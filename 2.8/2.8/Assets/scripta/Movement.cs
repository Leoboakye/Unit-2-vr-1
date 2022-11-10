using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 10.0f;
    Transform player;
    Vector2 xmove;
    float xMovement;
    float yMovement;



    // Start is called before the first frame updateif(Input.GetButton("jump
    void Start()
    {
        player = gameObject.transform;

    }

    // Update is called once per frame
    void Update()
    {
        xMovement = Input.GetAxis("Horizontal") * speed;
        yMovement = Input.GetAxis("Vertical") * speed;
        xmove = new Vector2(xMovement, yMovement);
        player.Translate(xmove * Time.deltaTime);

        if (Input.GetAxis("Horizontal") > 0)

        {
            player.localScale = new Vector3(-5.0f, 5.0f, 1.0f);
        }

        if (Input.GetAxis("Horizontal") < 0)
        {
            player.localScale = new Vector3(5.0f, 5f, 1.0f);
        }


    }
}
