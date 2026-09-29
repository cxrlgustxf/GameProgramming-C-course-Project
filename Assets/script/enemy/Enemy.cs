using UnityEngine;

public class Enemy : MonoBehaviour
{

    public Animator animator;
    public Movement movement;
    public StateManager stateManager;

    public 
    void Awake()
    {
       animator = GetComponent<Animator>();
       movement = GetComponent<Movement>();
       stateManager = GetComponent<StateManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void HandleAnimation()
    {
        
    }
}
