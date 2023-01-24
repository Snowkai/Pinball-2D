using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Petal : MonoBehaviour
{
    public float zAngleRight;
    public float zAngleLeft;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    public void RightRotate()
    {
        rb.rotation = zAngleRight;
        //gameObject.transform.Rotate(Vector3.back * Time.deltaTime, zAngle);
    }

    public void RighttStart()
    {
        rb.rotation = -70f;
    }

    public void LeftRotate()
    {
        rb.rotation = zAngleLeft;
        //gameObject.transform.Rotate(Vector3.back * Time.deltaTime, -zAngle);
    }
    public void LeftStart()
    {
        rb.rotation = 70f;
    }
}
