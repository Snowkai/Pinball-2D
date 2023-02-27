using UnityEngine;

public class Mushroom : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite spriteblue;
    public Sprite spritered;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        spriteRenderer.sprite = spritered;

    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        spriteRenderer.sprite = spriteblue;
    }

}
