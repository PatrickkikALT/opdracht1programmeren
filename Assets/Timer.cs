using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float time;
    public TMP_Text timer;
    void Update()
    {
        time = Time.timeSinceLevelLoad;
        timer.SetText(time.ToString());
    }
}
