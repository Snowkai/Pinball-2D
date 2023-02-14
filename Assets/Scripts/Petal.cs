using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Petal : MonoBehaviour
{
    public float rightAngle;
    public float leftAngle;
    public float rotationSpeed;
    public float startPosition;
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
        // currentEulerAngle = new Vector3(0, 0, rightAngle) * Time.deltaTime * rotationSpeed;
        // transform.eulerAngles = currentEulerAngle;
        transform.rotation = Quaternion.AngleAxis(rightAngle,Vector3.forward);

    }
    public void TurnLeft() 
    {
        transform.rotation = Quaternion.AngleAxis(leftAngle, Vector3.forward);
    }
    public void StartPosition() 
    {
        transform.rotation = startRotation;
    }
}
