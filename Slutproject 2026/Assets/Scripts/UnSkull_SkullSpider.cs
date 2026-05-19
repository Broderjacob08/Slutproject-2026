using System.Security.Cryptography;
using TMPro;
using UnityEngine;
//Alexander


public class UnSkull_SkullSpider : MonoBehaviour
{
    public TextMeshProUGUI HPCounter;

    public Enemy_Stats Unskulled_Spider;

    Enemy_Attacks bite = new Enemy_Attacks("Fiery Crunch", 10, 0, 1);

    Enemy_Attacks LavaSpray = new Enemy_Attacks("Fire storm", 20, 0, 10);

    private void Start()
    {
        Unskulled_Spider = new Enemy_Stats("Unskulled Skull-spider", 200, 200, 10);
    }

    public int EnemyAttackChoice()
    {
        string AttackName;

        int NextAttack = Random.Range(1, 4);

        if(NextAttack == 1)
        {
            int FieryCrunch = Unskulled_Spider.baseModifier + bite.Abilitydmg;

            AttackName = "Firey Crunch";
            print("crunch");
            return FieryCrunch;
            

        }else if(NextAttack == 2)
        {
            int FireStorm = Unskulled_Spider.baseModifier + LavaSpray.Abilitydmg;

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
        Unskulled_Spider.currentHP -= amount;
        if (Unskulled_Spider.currentHP < 0) Unskulled_Spider.currentHP = 0;
    }
    private void Update()
    {
        HPCounter.text = Unskulled_Spider.currentHP + "of" + Unskulled_Spider.maxHP;
    }

}
