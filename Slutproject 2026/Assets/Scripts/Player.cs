using Assets.Scripts;
using TMPro;
using UnityEngine;
//Alexander

public class Player : MonoBehaviour
{
    public TextMeshProUGUI HPCounter;

    public Player_Stats Hero;

    Weapon Sword = new Weapon("Great sword", 15, 100, 1);

    private void Start()
    {
        Hero = new Player_Stats("Hero", 100, 100, 10);
    }
    public int SwordDamage()
    {
        int SwordDamage = Hero.basedmg + Sword.Abilitydmg;

        return SwordDamage;
    }

    public void TakeDamage(int amount)
    {
        Hero.currentHP -= amount;
        if (Hero.currentHP < 0) Hero.currentHP = 0;
    }
    private void Update()
    {
        HPCounter.text = Hero.currentHP + "of" + Hero.maxHP;
    }
}
