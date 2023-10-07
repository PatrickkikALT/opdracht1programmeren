using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public TMP_Text score;
    public GameObject counter;
    public int totalScore;

    void Update()
    {
        totalScore = counter.GetComponent<SpikeDestroyer>().score;
        score.SetText("Score: " + totalScore);
    }
}
