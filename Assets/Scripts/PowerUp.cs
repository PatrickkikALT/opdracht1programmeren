using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public GameObject player;
    public float baseSpeed;
    public float powerUpSpeed;
    public float jumpPowerUp;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PowerUp"))
        {
            if (player.GetComponent<Movement>().speed >= baseSpeed)
            {
                player.GetComponent<Movement>().speed += powerUpSpeed;
                collision.gameObject.SetActive(false);
                player.GetComponent<Movement>().jumpVelocity += jumpPowerUp;
            }
        }
    }
}
