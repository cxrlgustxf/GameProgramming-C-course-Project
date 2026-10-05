using UnityEngine;


public class Movement
{


    public Vector2 GetMovement(Vector2 input, float speed)
    {
        Vector2 movementInput = input;
        movementInput = movementInput.normalized;
        
        Vector2 FinalMovement = movementInput * speed;
        return FinalMovement;
    }
}
