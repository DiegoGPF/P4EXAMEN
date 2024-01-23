using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Statistics : MonoBehaviour
{
    public Text score, time;
    public static int scoreInt;
    public static float timer;
    void Start()
    {
        
    }
    void Update()
    {
        timer -= Time.deltaTime;
        score.text = "Score: " + scoreInt;
    }
}
