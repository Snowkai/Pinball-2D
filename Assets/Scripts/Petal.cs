using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Petal : MonoBehaviour
{
    public float rotateAngle;
    public float rotationSpeed;
    private Quaternion startRotation;

    // Start is called before the first frame update
    void Start()
    {
        startRotation = transform.rotation;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            TurnLeft();
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            StartPosition();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            TurnRight();
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            StartPosition();
        }
    }
    public void TurnRight()
    {
        Vector3 rotation = new Vector3(0,0,rotateAngle);
        //transform.rotation = Quaternion.Euler(rotation);
        float timespeed = (transform.rotation.z - rotateAngle) / Time.deltaTime;
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(rotation), timespeed);
    }
    public void TurnLeft() 
    {
        Vector3 rotation = new Vector3(0, 0, rotateAngle);
        //transform.rotation = Quaternion.Euler(rotation);
        float timespeed = (transform.rotation.z - rotateAngle) / Time.deltaTime;
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(rotation), timespeed);
    }
    public void StartPosition() 
    {
        transform.rotation = startRotation;
    }
}
