using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VallendObject : MonoBehaviour
{
    [SerializeField] GameObject spikePrefab;
    [SerializeField] GameObject powerUpPrefab;
    private float minX = -9, maxX = 9;
    private float timeMin = 0.5f, timeMax = 3;
    private float powerUpMin = 15, powerUpMax = 30;
    void Start()
    {
        Invoke("SpawnSpike", Random.Range(timeMin, timeMax));
        Invoke("SpawnPowerUp", Random.Range(powerUpMin, powerUpMax));
    }
    void SpawnSpike()
    {
        float randPosx = Random.Range(minX, maxX);
        spikePrefab = Instantiate(spikePrefab, new Vector2(randPosx, transform.position.y), Quaternion.identity);
        spikePrefab.SetActive(true);
        Invoke("SpawnSpike", Random.Range(timeMin, timeMax));
    }
    void SpawnPowerUp()
    {
        float randPosx = Random.Range(minX, maxX);
        powerUpPrefab = Instantiate(powerUpPrefab, new Vector2(randPosx, transform.position.y), Quaternion.identity);
        powerUpPrefab.SetActive(true);
        Invoke("SpawnPowerUp", Random.Range(powerUpMin, powerUpMax));
    }
}