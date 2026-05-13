using Assets.Scripts;
using UnityEngine;

public class Player : MonoBehaviour
{
    Player_Stats Hero = new Player_Stats("Hero", 100, 100, 10);

    Weapon Sword = new Weapon("Great sword", 15, 100, 1);

    public int SwordDamage()
    {
        int SwordDamage = Hero.basedmg + Sword.Abilitydmg;

        return SwordDamage;
    }

}
