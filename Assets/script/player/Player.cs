using UnityEngine;
using UnityEngine.Windows;

public class Player : MonoBehaviour
{


    public Rigidbody2D rb;
    public Animations animations;
    public InputManager input;

    public CircleCollider2D attackArea;

    void Start()
    {
        animations = GetComponent<Animations>();
        input = GetComponent<InputManager>();
        rb = GetComponent<Rigidbody2D>();
        attackArea = GetComponent<CircleCollider2D>();
    }


    void Update()
    {
        
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Enemy"))
        {

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }
}
