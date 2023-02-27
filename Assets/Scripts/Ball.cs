using UnityEngine;

public class Ball : MonoBehaviour
{
    GameObject hg;
    HighScore score;
    public int mushroom;
    public int platform;
    // Start is called before the first frame update
    void Start()
    {
        hg = GameObject.Find("HighScore");
        score = hg.GetComponent<HighScore>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "mushroom")
        {
            score.AddScore(mushroom);
        }
        if (collision.gameObject.tag == "platform")
        {
            score.AddScore(platform);
        }
    }
}
