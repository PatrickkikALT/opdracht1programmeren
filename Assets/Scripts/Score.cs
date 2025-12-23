using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public TMP_Text score;
    public GameObject counter;
    public int totalScore;

    void Update()
    {
        totalScore = counter.GetComponent<SpikeDestroyer>().score;
        score.SetText("Score: " + totalScore);

        if (totalScore >= 25)
        {
            SceneManager.LoadScene("Level2");
        }
    }
}
