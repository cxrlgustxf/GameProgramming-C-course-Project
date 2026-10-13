using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class AutoAttack : MonoBehaviour
{
    [SerializeField] Player player;
    PlayerStats stats;

    void Awake()
    {
        stats = player.GetComponentInParent<PlayerStats>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            
        }
    }
}
