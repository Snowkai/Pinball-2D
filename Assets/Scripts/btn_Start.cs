using UnityEngine;

public class btn_Start : MonoBehaviour
{
    public GameObject ball;
    public Transform parent;
    public Vector2 position;
    public Quaternion rotation;
    public GameObject directPush;
    // Start is called before the first frame update
    void Start()
    {
        ball = Instantiate(ball, position, rotation, parent);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartAction()
    {
        Rigidbody2D bd = ball.GetComponent<Rigidbody2D>();
        Vector2 dp = directPush.GetComponent<Transform>().position;
        Vector2 bp = ball.GetComponent<Transform>().position;
        Vector2 result = dp - bp;
        bd.AddForce(result * Random.Range(1.1f, 1.3f), ForceMode2D.Impulse);
        gameObject.SetActive(false);
    }
    public void CreateBall()
    {
        ball = Instantiate(ball, position, rotation, parent);
    }
}
