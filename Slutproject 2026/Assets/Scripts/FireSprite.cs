using TMPro;
using UnityEngine;
//Alexander

public class FireSprite : Enemy_class_IDK
{
    public TextMeshProUGUI HPCounter;

    public Enemy_Stats Fire_Spirit;

    Enemy_Attacks burn = new Enemy_Attacks("Spirit Flame", 5, 0, 1);

    private void Start()
    {
        Fire_Spirit = new Enemy_Stats("Fire spirit", 50, 50, 5);
    }
    public void StopFireSpiritAnimation()
    {
        GetComponent<Animator>().SetBool("Attack", false);
    }
    public void StartFireSpiritAnimation()
    {
        GetComponent<Animator>().SetBool("Attack", true);
    }
    public void FireSpiritDeathAnimation()
    {
        GetComponent<Animator>().SetBool("Death", true);
    }


    public int EnemyAttackChoice()
    {
        string AttackName;

        int NextAttack = Random.Range(1, 3);

        if (NextAttack == 1)
        {
            int SpiritFlame = Fire_Spirit.baseModifier + burn.Abilitydmg;

            AttackName = "Spirit Flame";
            print("burn");
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
