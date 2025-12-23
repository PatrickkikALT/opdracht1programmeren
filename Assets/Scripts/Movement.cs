using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float hor;
    public float vert;
    public Vector3 dir;
    public float speed;
    public bool onGround;
    public Rigidbody2D rb;
    public float jumpVelocity;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        hor = Input.GetAxis("Horizontal");
        vert = Input.GetAxis("Vertical");
        dir.x = hor;
        dir.z = -hor;
        transform.Translate(dir * (speed * Time.deltaTime));
        
        if (vert >= 0.1 && onGround)
        {
            rb.velocity = new Vector3 (0, jumpVelocity, 0);
            onGround = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            onGround = true;
        }
    }
}
