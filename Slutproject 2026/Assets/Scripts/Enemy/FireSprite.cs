using TMPro;
using UnityEngine;
//Alexander

public class FireSprite : Enemy_class_IDK
{
    public TextMeshProUGUI HPCounter;

    

    Enemy_Attacks burn = new Enemy_Attacks("Spirit Flame", 5, 0, 1);

    private void Start()
    {
        Enemy_Stats = new Enemy_Stats("Fire spirit", 50, 50, 5);
    }
    


    public override int EnemyAttackChoice()
    {
        string AttackName;

        int NextAttack = Random.Range(1, 3);

        if (NextAttack == 1)
        {
            int SpiritFlame = Enemy_Stats.baseModifier + burn.Abilitydmg;

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
        Enemy_Stats.currentHP -= amount;
        if (Enemy_Stats.currentHP < 0) Enemy_Stats.currentHP = 0;
    }
    private void Update()
    {
        HPCounter.text = Enemy_Stats.currentHP + "of" + Enemy_Stats.maxHP;
    }

}
