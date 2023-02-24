using UnityEngine;

public class Petal : MonoBehaviour
{
    public float rotateAngle;
    public float speed;
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
        Vector3 rotation = new Vector3(0, 0, rotateAngle);
        for (float wtime=0f; wtime < 1f;wtime = speed * Time.deltaTime )
        {
            transform.rotation = Quaternion.Lerp(startRotation, Quaternion.Euler(rotation), wtime);
        }

    }
    public void TurnLeft()
    {
        Vector3 rotation = new Vector3(0, 0, rotateAngle);
        for (float wtime = 0f; wtime < 1f; wtime = speed * Time.deltaTime)
        {
            transform.rotation = Quaternion.Lerp(startRotation, Quaternion.Euler(rotation), wtime);
        }

    }
    public void StartPosition()
    {
       /*for (float wtime = 0f; wtime < 1f; wtime = speed * Time.deltaTime)
        {
            transform.rotation = Quaternion.Lerp(endRotation, startRotation, wtime);
        }*/
       transform.rotation= startRotation;
    }
}
