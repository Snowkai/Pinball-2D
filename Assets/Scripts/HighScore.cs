using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HighScore : MonoBehaviour
{
    public int mushroom;
    public int platform;
    private int Score { get; set; }
    private TextMeshProUGUI scoretext;

    // Start is called before the first frame update
    void Start()
    {   
        scoretext= GetComponent<TextMeshProUGUI>();
        ResetScore();
    }
    // Update is called once per frame
    void Update()
    {       
    }
    public void AddScore(int value)
    {
        Score+= value;
        scoretext.text = Score.ToString();
        Debug.Log(scoretext.text);
    }
    public void ResetScore()
    {
        Score = 0;
        scoretext.text= Score.ToString();
    }
}
