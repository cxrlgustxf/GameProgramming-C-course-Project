using UnityEngine;

public class player : MonoBehaviour
{

    private Animator animations;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animations = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
