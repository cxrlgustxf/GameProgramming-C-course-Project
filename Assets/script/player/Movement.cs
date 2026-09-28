using UnityEngine;


public class Movement
{


    public Vector2 GetMovement(Vector2 input, float speed)
    {
        Vector2 movement = input * speed;
        movement = movement.normalized;
        return movement;
    }
}
