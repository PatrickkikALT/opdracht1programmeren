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
        //spawnt de eerste spike en powerup
        Invoke("SpawnSpike", Random.Range(timeMin, timeMax));
        Invoke("SpawnPowerUp", Random.Range(powerUpMin, powerUpMax));
    }
    void SpawnSpike()
    {
        //function spawnt de spike op een random positie en op een random tijdstip tussen de min en max seconden
        float randPosx = Random.Range(minX, maxX);
        GameObject newSpike = Instantiate(spikePrefab, new Vector2(randPosx, transform.position.y), Quaternion.identity);
        Invoke("SpawnSpike", Random.Range(timeMin, timeMax));
    }
    void SpawnPowerUp()
    {
        //zelfde script als spike maar spawnt dan een powerup met een andere min en max in seconden
        float randPosx = Random.Range(minX, maxX);
        GameObject newSpike = Instantiate(powerUpPrefab, new Vector2(randPosx, transform.position.y), Quaternion.identity);
        Invoke("SpawnPowerUp", Random.Range(powerUpMin, powerUpMax));
    }
}