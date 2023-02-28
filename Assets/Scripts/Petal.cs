using System.Threading;
using UnityEngine;

public class Petal : MonoBehaviour
{
    public float angle;
    public float speed = 0.01f;
    Quaternion startRotation;

    // Start is called before the first frame update
    void Start()
    {
        startRotation = transform.rotation;
    }
    private void Update()
    {

    }
    public void Turn()
    {
        Vector3 euler = new Vector3(0,0,angle);
        Quaternion endRotation = Quaternion.Euler(euler);
        for (float w = 0f; w < 1; w = w + Time.deltaTime) {
            transform.rotation = Quaternion.Lerp(startRotation, endRotation,w);
        }
    }
    public void StartPosition()
    {
        Vector3 euler = new Vector3(0, 0, angle);
        Quaternion endRotation = Quaternion.Euler(euler);
        for (float w = 1f; w > 0; w = w - Time.deltaTime)
        {
            transform.rotation = Quaternion.Lerp(startRotation, endRotation, w);
        }
    }
}
