using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Petal : MonoBehaviour
{
    public float rotateAngle;
    public float rotationSpeed;
    private Vector3 currentEulerAngle;
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
        currentEulerAngle = new Vector3(0, 0, rotateAngle) * Time.deltaTime * rotationSpeed;
        transform.eulerAngles = currentEulerAngle;
        //transform.rotation = Quaternion.AngleAxis(rightAngle,Vector3.forward);

    }
    public void TurnLeft() 
    {
        transform.rotation = Quaternion.AngleAxis(rotateAngle, Vector3.forward);
    }
    public void StartPosition() 
    {
        transform.rotation = startRotation;
    }
}
