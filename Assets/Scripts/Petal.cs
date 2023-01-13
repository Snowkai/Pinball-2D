using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Petal : MonoBehaviour
{
    public float zAngle;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void RightRotate()
    {
        gameObject.transform.Rotate(Vector3.back * Time.deltaTime, zAngle);
    }

    public void LeftRotate()
    {
        gameObject.transform.Rotate(Vector3.back * Time.deltaTime, -zAngle);
    }

}
