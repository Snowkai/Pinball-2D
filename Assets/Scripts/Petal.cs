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
        gameObject.transform.Rotate(Vector3.up, zAngle);
    }

    public void LeftRotate()
    {
        gameObject.transform.Rotate(Vector3.forward,zAngle);
    }

}
