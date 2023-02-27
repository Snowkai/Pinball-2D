using UnityEngine;

public class EndPlatform : MonoBehaviour
{
    public GameObject btn_start;
    private btn_Start btnScript;

    // Start is called before the first frame update
    void Start()
    {
        btnScript = btn_start.GetComponent<btn_Start>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject ball = GameObject.FindGameObjectWithTag("Ball");
        Destroy(ball);
        btn_start.SetActive(true);
        btnScript.CreateBall();
    }
}
