using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Mushroom : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite spriteblue;
    public Sprite spritered;    
    public UnityEvent OnEvent;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        spriteRenderer.sprite = spritered;
        OnEvent.Invoke();
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        spriteRenderer.sprite = spriteblue;
    }

}
