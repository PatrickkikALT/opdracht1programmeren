using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public GameObject player;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("PowerUp"))
        {
            if (player.GetComponent<Movement>().speed < 0.16f)
            {
                player.GetComponent<Movement>().speed += 0.1f;
                collision.gameObject.SetActive(false);
            }
        }
    }
}
