using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeDestroyer : MonoBehaviour
{
    public int score;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Spike"))
        {
            score += 1;
            collision.gameObject.SetActive(false);
        }
        if (collision.gameObject.CompareTag("PowerUp"))
        {
            score -= 2;
            collision.gameObject.SetActive(false);
        }
    }
}
