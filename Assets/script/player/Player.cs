using UnityEngine;
using UnityEngine.Windows;

public class Player : MonoBehaviour
{


    public Rigidbody2D rb;
    public Animations animations;
    public InputManager input;

    public CircleCollider2D attackArea;

    public float AttackCooldown;
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

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {

        }

    }


    private bool Cooldown(float newTime)
    {
        if (AttackCooldown>0) {
            AttackCooldown = newTime;
            return false;
        }
        AttackCooldown -= Time.deltaTime;
        return true;

    }
}
