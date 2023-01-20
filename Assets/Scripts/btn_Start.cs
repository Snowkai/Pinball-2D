using System.Collections;
using System.Collections.Generic;
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
        Instantiate(ball, position, rotation, parent);
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
        Debug.Log(dp);
        Debug.Log(bp);
        Debug.Log(result);
        bd.AddForce(result, ForceMode2D.Impulse);
    }
}
