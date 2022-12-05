using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public float speed = 10.0f;
    Transform player;
    Vector2 xmove;
    float xMovement;
    float yMovement;
    public Animator animator;
    Rigidbody2D m_Rigidbody;
    public float m_Thrust = 1.0f;
    public static int acorn;
    public static int health;

    // Start is called before the first frame updateif(Input.GetButton("jump
    void Start()
    {
        player = gameObject.transform;
        animator = GetComponent<Animator>();
        m_Rigidbody = GetComponent<Rigidbody2D>();
        health = 5;
    }

    // Update is called once per frame
    void Update()
    {
        xMovement = Input.GetAxis("Horizontal") * speed;
        animator.SetFloat("Speed", Mathf.Abs(xMovement));
        yMovement = Input.GetAxis("Vertical") * speed;
        xmove = new Vector2(xMovement, yMovement);
        player.Translate(xmove * Time.deltaTime);

        if (xMovement > 0)

        {
            player.localScale = new Vector3(5.0f, 5.0f, 1.0f);
        }

        if (xMovement < 0)
        {
            player.localScale = new Vector3(-5.0f, 5f, 1.0f);
        }

        if (yMovement > 0)
        {
            m_Rigidbody.AddForce(transform.up * m_Thrust);
            animator.SetBool("itsJumping", true);

        }
        if (health == 0)
        {
            SceneManager.LoadScene("Gameover");
        }
    }

   
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "acorn")
        {
            animator.SetBool("itsJumping", false);
            Debug.Log("NOM NOM NOM");
            acorn = acorn += 1;
        }

        if (col.gameObject.tag == "ground")
        {
            animator.SetBool("itsJumping", false);
        }
        if (col.gameObject.tag == "enemy")
        {
            Debug.Log("ouch");
            health = health -= 1;
        }


        if (col.gameObject.tag == "tp")
        {

            SceneManager.LoadScene("GS2");
        }
    }

    void OnBecameInvisible()
    {
        health = 0;
        Debug.Log("Game Over!");

    }

}