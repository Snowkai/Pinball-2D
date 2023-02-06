using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HighScore : MonoBehaviour
{
    private int score;
    [SerializeField] private TextMeshProUGUI scoretext;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoretext.text = "TEST";
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void AddScore(int value)
    {
        score += value;
        scoretext.text = score.ToString();
    }
    public void ResetScore()
    {
        score = 0;
    }
}
