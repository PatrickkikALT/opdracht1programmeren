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
    public float jumpForce = 10.0f;
    void FixedUpdate()
    {
        hor = Input.GetAxis("Horizontal");
        vert = Input.GetAxis("Vertical");
        dir.x = hor;
        dir.z = -hor;
        if (vert > 0)
        {
            if (onGround)
            {
                vert = 1;
                dir.y = vert * jumpForce;
                GetComponent<Transform>().position += dir * speed;
            }
            while (vert > 0 && vert < 1) {
                dir.y = vert - 0.1f;
            }
        }
        else
        {
            dir.y = 0;
            GetComponent<Transform>().position += dir * speed;
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
