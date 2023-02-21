using System.Collections;
using System.Collections.Generic;
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
        transform.rotation = Quaternion.Slerp(startRotation,Quaternion.Euler(0,0,rotateAngle),Time.deltaTime*rotationSpeed);
    }
    public void TurnLeft() 
    {
        transform.rotation = Quaternion.Slerp(startRotation, Quaternion.Euler(0, 0, rotateAngle),Time.deltaTime * rotationSpeed);
    }
    public void StartPosition() 
    {
        transform.rotation = startRotation;
    }
}
