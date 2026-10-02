using UnityEngine;

public class Animations : MonoBehaviour
{
    public Animator animator;

    public float LastX;
    public float LastY;
    void Awake()
    {
        animator = GetComponent<Animator>();
    }



    public void SetAnimation(float movementx, float movementy, bool isWalking)
    {

        if (isWalking) 
        {
            animator.SetFloat("CurrentInputX", movementx);
            animator.SetFloat("CurrentInputY", movementy);
            LastX = movementx;
            LastY = movementy;
            animator.SetBool("IsWalking", true);
        }
        else
        {

            animator.SetFloat("LastInputX", LastX);
            animator.SetFloat("LastInputY", LastY);
            animator.SetBool("IsWalking", false);
        }


    }


}
