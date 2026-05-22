using System.Security.Cryptography;
using TMPro;
using UnityEngine;
//Alexander


public class UnSkull_SkullSpider : Enemy_class_IDK
{
    public TextMeshProUGUI HPCounter;

    

    Enemy_Attacks bite = new Enemy_Attacks("Fiery Crunch", 10, 0, 1);

    Enemy_Attacks LavaSpray = new Enemy_Attacks("Fire storm", 20, 0, 10);

    

    private void Start()
    {
        Enemy_Stats = new Enemy_Stats("Unskulled Skull-spider", 200, 200, 10);
    }

    
    

    public override int EnemyAttackChoice()
    {
        string AttackName;

        int NextAttack = Random.Range(1, 4);

        if(NextAttack == 1)
        {
            int FieryCrunch = Enemy_Stats.baseModifier + bite.Abilitydmg;

            AttackName = "Firey Crunch";
            print("crunch");

            return FieryCrunch;
            

        }else if(NextAttack == 2)
        {
            int FireStorm = Enemy_Stats.baseModifier + LavaSpray.Abilitydmg;

            AttackName = "Fire Storm";
            print("Storm");
            return FireStorm;

        }else if(NextAttack == 3)
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
