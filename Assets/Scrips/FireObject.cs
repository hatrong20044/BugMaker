using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireObject : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] Vector2 _force;
    [SerializeField] bool _isGround=false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&& _isGround)
        {
            rb.AddForce(_force);
            _isGround = false;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.AddForce(Vector2.left*_force);
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag==("Ground"))
        {

            _isGround = true;
        }
    }
}
