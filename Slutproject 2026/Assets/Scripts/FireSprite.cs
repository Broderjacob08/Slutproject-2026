using TMPro;
using UnityEngine;
//Alexander

public class FireSprite : MonoBehaviour
{
    public TextMeshProUGUI HPCounter;

    public Enemy_Stats Fire_Spirit;

    Enemy_Attacks burn = new Enemy_Attacks("Spirit Flame", 5, 0, 1);

    private void Start()
    {
        Fire_Spirit = new Enemy_Stats("Fire spirit", 50, 50, 5);
    }

    public int EnemyAttackChoice()
    {
        string AttackName;

        int NextAttack = Random.Range(1, 3);

        if (NextAttack == 1)
        {
            int SpiritFlame = Fire_Spirit.baseModifier + burn.Abilitydmg;

            AttackName = "Firey Crunch";
            print("crunch");
            return SpiritFlame;


        }
        else if (NextAttack == 2)
        {
            int FailedAttack = 0;

            AttackName = "Attack failed";
            print("failed");
            return FailedAttack;

        }
        return NextAttack;

    }
    public void TakeDamage(int amount)
    {
        Fire_Spirit.currentHP -= amount;
        if (Fire_Spirit.currentHP < 0) Fire_Spirit.currentHP = 0;
    }
    private void Update()
    {
        HPCounter.text = Fire_Spirit.currentHP + "of" + Fire_Spirit.maxHP;
    }

}
