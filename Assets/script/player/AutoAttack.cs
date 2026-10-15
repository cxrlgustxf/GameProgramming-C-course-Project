
using UnityEngine;

public class AutoAttack : MonoBehaviour
{
    [SerializeField] Player player;

    public Weapon[] weapon;
    

    void Awake()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            weapon.Attack(player.transform.position, collision.gameObject.transform.position);
            Debug.Log("Attacked!");
        }
    }
}
