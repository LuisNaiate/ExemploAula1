using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlerplayes : MonoBehaviour
{
    public float speed = 5, jumpStrenght = 5;
    public Rigidbody2D body;
     public float horizontal;
    bool groundCheck;
    public Transform foot;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        body.velocity = new Vector2 (horizontal * speed, body.velocity.y);

        groundCheck = Physics2D.OverlapCircle(foot.position, 0.005f);

        if (Input.GetButtonDown("Jump") && groundCheck)
        {
            body.AddForce(new Vector2(0, jumpStrenght * 100));
        }
    }
}
