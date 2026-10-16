using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{



    public Rigidbody2D rb;
    public Animations animations;
    public InputManager input;
    public CircleCollider2D attackArea;
    public PlayerStats stats;
    public StateIdle stateIdle;
    public StateMove stateMove;

    


    void Awake()
    {
        animations = GetComponent<Animations>();
        input = GetComponent<InputManager>();
        rb = GetComponent<Rigidbody2D>();
        attackArea = GetComponent<CircleCollider2D>();

        stateIdle = new StateIdle();
        stateMove = new StateMove();

        stats = new PlayerStats();

        
    }

    void Start()
    {
        stats.InitStats(1f);
    }
    void Update()
    {

        stats.HandleUpdates();

    }

    





}