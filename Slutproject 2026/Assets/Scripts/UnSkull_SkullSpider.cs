using System.Security.Cryptography;
using TMPro;
using UnityEngine;
//Alexander


public class UnSkull_SkullSpider : MonoBehaviour
{
    public TextMeshProUGUI HPCounter;

    Enemy_Stats Unskulled_Spider = new Enemy_Stats("Unskulled Skull-spider", 200, 200, 10);

    Enemy_Attacks bite = new Enemy_Attacks("Fiery Crunch", 10, 0, 1);

    Enemy_Attacks LavaSpray = new Enemy_Attacks("Fire storm", 20, 0, 10);

    public int EnemyAttackChoice()
    {
        Random RNG = new Random();

        int NextAttack = RNG.Next(1, 3);

        if(NextAttack == 1)
        {
            int FieryCrunch = Unskulled_Spider.baseModifier + bite.Abilitydmg;

            return FieryCrunch;

        }else if(NextAttack == 2)
        {
            int FireStorm = Unskulled_Spider.baseModifier + LavaSpray.Abilitydmg;

            return FireStorm;
        }
    }
    
}
