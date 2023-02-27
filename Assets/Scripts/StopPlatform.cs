using UnityEngine;

public class StopPlatform : MonoBehaviour
{
    Collider2D box;
    // Start is called before the first frame update
    void Start()
    {
        box = gameObject.GetComponent<Collider2D>();
        box.isTrigger = true;
    }
    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        box.isTrigger = false;
    }
}
