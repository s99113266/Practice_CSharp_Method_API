using UnityEngine;

public class FoxScript : MonoBehaviour
{
    [Header("移動速度"),Range(0.1f, 100f)]
    public float Speed = 10.0f;
    public Rigidbody2D rb2D;
    public SpriteRenderer _spriteRenderer;
    
    private void Start()
    {
        //rb2D.gameObject.AddComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        switch (h)
        {
            case 1:
                print("1");
                rb2D.AddForce(new Vector2(1, 0) * Speed);
                _spriteRenderer.flipX = false;
                break;
            case -1:
                print("-1");
                rb2D.AddForce(new Vector2(1, 0) * -Speed);
                _spriteRenderer.flipX = true;
                break;
        }
        //print( * Speed);
    }
}
