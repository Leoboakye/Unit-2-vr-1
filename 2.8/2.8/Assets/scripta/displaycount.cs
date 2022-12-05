using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class displaycount : MonoBehaviour
{
    public Text acornText;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        acornText.text = "acorn :" + Movement.acorn;
        if (Input.GetKeyDown(KeyCode.Space))
        {

            

        }
        
    }
}
