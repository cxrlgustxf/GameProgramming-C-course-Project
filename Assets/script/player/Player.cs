using UnityEngine;
using UnityEngine.Windows;

public class Player : MonoBehaviour
{


    public Rigidbody2D rb;
    public Animations animations;
    public InputManager input;

    void Start()
    {
        animations = GetComponent<Animations>();
        input = GetComponent<InputManager>();
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        
    }
}
