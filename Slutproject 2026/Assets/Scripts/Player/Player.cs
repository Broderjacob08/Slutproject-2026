using Assets.Scripts;
using TMPro;
using UnityEngine;
//Alexander

public class Player : MonoBehaviour
{
    public TextMeshProUGUI HPCounter;
    

    public Player_Stats Hero;

    public int currentMana;
    public TextMeshProUGUI ManaCounter;

    Weapon Sword = new Weapon("Great sword", 15, 100, 1);

    Spell Wave = new Spell("Wave Rage", 30, 250, 10, 2);

    Spell bubble = new Spell("Bubbles of Lifestealing", 10, 300, 1, 2);

    private void Start()
    {
        Hero = new Player_Stats("Hero", 100, 100, 10);
    }
    public int SwordDamage()
    {
        int BonusModifier = Random.Range(5, 10);
        
        int SwordDamage = Hero.basedmg + Sword.Abilitydmg + BonusModifier;

        currentMana += SwordDamage;

        return SwordDamage;
    }
    public int HealSpell()
    {
        currentMana -= 25;
        
        int BonusModifier = Random.Range(5, 15);

        int HealEffect = Hero.basedmg * -1 - BonusModifier;

        return HealEffect;
    }
    public int WaveRage()
    {
        currentMana -= 100;
        
        int BonusModifier = Random.Range(10, 25);

        int WaveRageDamage = Hero.basedmg + Wave.Abilitydmg + BonusModifier;

        return WaveRageDamage;
    }
    public int LifestealBubbles()
    {
        currentMana -= 80;
        
        int BonusModifier = Random.Range(1, 20);

        int LifestealBubblesDamage = Hero.basedmg + bubble.Abilitydmg + BonusModifier;

        return LifestealBubblesDamage;
    }

    public void TakeDamage(int amount)
    {
        Hero.currentHP -= amount;
        if (Hero.currentHP < 0) Hero.currentHP = 0;
    }
    private void Update()
    {
        HPCounter.text = Hero.currentHP + "of" + Hero.maxHP;
        ManaCounter.text = "Mana: " + currentMana;
    }
}
