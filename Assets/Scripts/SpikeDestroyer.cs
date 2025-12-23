using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpikeDestroyer : MonoBehaviour
{
    public int score;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Spike"))
        {
            score += 1;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("PowerUp"))
        {
            score -= 2;
            Destroy(collision.gameObject);
        }
    }
}
