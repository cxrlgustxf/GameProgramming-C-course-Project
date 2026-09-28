using UnityEngine;

public class Animations : MonoBehaviour
{
    public Animator animator;
    
    void Awake()
    {
        animator = GetComponent<Animator>();
    }



    public void SetAnimation(float movementx, float movementy)
    {
        animator.SetFloat("walk_x", movementx);
        animator.SetFloat("walk_y", movementy);

    }
}
