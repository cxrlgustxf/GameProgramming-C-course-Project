using TMPro;
using UnityEngine;

public class LevelUpScreen : MonoBehaviour
{

    GameObject playerObject;
    Player player;
    GameObject weaponObject;

    Weapon weapon;
    [SerializeField] TextMeshProUGUI Button1;
    [SerializeField] TextMeshProUGUI Button2;





    private void Awake()
    {

        playerObject = GameObject.FindWithTag("Player");
        player = playerObject.GetComponent<Player>();

        weaponObject = GameObject.FindWithTag("Weapon");
        weapon = weaponObject.GetComponent<Weapon>();

        Time.timeScale = 0f;
    }



    public void UpgradeHP() 
    {
        if (player.stats.PlayerLevel >= 2)
        {
            player.stats.MaxHealth += 5;
            player.stats.OnUpgrade(1);

        }
        else
        {
            Debug.Log("Level wasnt high enough!");
        }

    }
    public void UpgradeDamage() 
    {
        if (player.stats.PlayerLevel >= 2)
        {
            weapon.Damage += 5f;


            player.stats.OnUpgrade(2);

        }

    }
    public void UpgradeAttackSpeed()
    {
        if (player.stats.PlayerLevel >= 2) {
            weapon.AttackSpeed += 1;
            

            player.stats.OnUpgrade(2);




        }

    }

    public void UpgradeAttackRate()
    {
        if (player.stats.PlayerLevel >= 3) 
        {
            weapon.AttackRate -= 0.2f;
            player.stats.OnUpgrade(3);

        }

    }
    public void UpgradeWeapon() 
    
    {
        if (player.stats.PlayerLevel >= 5)
        {
            if (weapon.CurrentWeapon <= 3)
            {
                weapon.CurrentWeapon += 1;
                weapon.InitWeapon();
                player.stats.OnUpgrade(5);
            }


        }
        else
        {
            Debug.Log("Level wasnt high enough!");
        }

    }

    public void SkipUpgrade()
    {
        player.stats.OnUpgrade(0);
        Time.timeScale = 1f;
        Destroy(gameObject);
    }



}

