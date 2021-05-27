using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    public float moveSpeed = 10f;
    public float jumpForce = 10f;
    
  

    void Start()
    {
   
    }

    // Update is called once per frame
    //comment something 
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)) 
        {
            rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }


    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "coin")
        {
            col.gameObject.SetActive(false);
        }
    }

}
