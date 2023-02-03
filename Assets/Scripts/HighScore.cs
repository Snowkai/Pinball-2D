using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HighScore : MonoBehaviour
{
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        gameObject.GetComponent<TextMeshPro>().text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<TextMeshPro>().text = score.ToString();
    }
    public void AddScore(int value)
    {
        score += value;
    }
}
