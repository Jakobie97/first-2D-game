using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    
  

    void Start()
    {
   
    }

    // Update is called once per frame
    //comment
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow)) 
        {
            rb.velocity = new Vector2(-10, rb.velocity.y);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(10, rb.velocity.y);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, 10f);
        }


    }

    void FixedUpdate()
    {

    }
}
