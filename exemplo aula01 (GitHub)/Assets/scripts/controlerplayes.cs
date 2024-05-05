using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlerplayes : MonoBehaviour
{
    public float speed;
    public Rigidbody2D body;
     public float horizontal;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        body.velocity = new Vector2 (horizontal * speed, body.velocity.y);
        
    }
}
