using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Playerhealth : MonoBehaviour
{
    int health = 5;
    public Text healthText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        healthText.text = "Health" + Movement.health.ToString();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            health--;
            Debug.Log("health -1");
        }
        if (health == 0)
        {
            Destroy(gameObject);
            Debug.Log("Game Over");
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "enemy")
        {
            Debug.Log("ouch");
            health = health -= 1;
        }

    }

    
}
