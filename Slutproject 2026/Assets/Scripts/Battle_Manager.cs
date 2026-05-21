using JetBrains.Annotations;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using System.Collections;
//Alexander
public enum BattleState
{
    Start, 
    PlayerTurn, 
    EnemyTurn, 
    Busy, 
    Won, 
    Lost
}
public class Battle_Manager : MonoBehaviour
{
    public BattleState state;

    TextMeshProUGUI StateName;

    public int WaveCooldown = 0;

    

    public Player playerUnit;
    public Enemy_class_IDK enemyUnit;
    public Enemy_class_IDK enemyUnit1;
    void Start()
    {
        StateName = GetComponent<TextMeshProUGUI>();
        state = BattleState.Start;
        StateName.text = "Battle Starting";

        
        SetupBattle();
    }

    void SetupBattle()
    {
        // Fixa hitpoint counter / set hitpoints / stats och whatever
        state = BattleState.PlayerTurn;
        StateName.text = "Hero Turn";



        PlayerTurn();
    }

    void PlayerTurn()
    {
        Debug.Log("Players turn");
        WaveCooldown -= 1;
        //Fixa UI för actions
    }
    public void OnWaveRageButton()
    {
        if (state != BattleState.PlayerTurn) return;
        if (WaveCooldown > 0) return;
        StartCoroutine(WaveRageSpell());
    }
    IEnumerator WaveRageSpell()
    {
        if(enemyUnit is UnSkull_SkullSpider E1)
        {

        }
        if(enemyUnit1 is FireSprite E2)
        {

        }
        
        state = BattleState.Busy;
        StateName.text = "Hero Action";



        yield return new WaitForSeconds(1f);

        enemyUnit.TakeDamage(playerUnit.WaveRage());
        enemyUnit1.TakeDamage(playerUnit.WaveRage());

        if (enemyUnit.Unskulled_Spider.currentHP <= 0)
        {
            enemyUnit.SkullSpiderDeathAnimation();
        }
        if (enemyUnit1.Fire_Spirit.currentHP <= 0)
        {
            enemyUnit1.FireSpiritDeathAnimation();
        }

        WaveCooldown = 3;

        if (enemyUnit.Unskulled_Spider.currentHP <= 0 && enemyUnit1.Fire_Spirit.currentHP <= 0)
        {
            state = BattleState.Won;
            StateName.text = "Enemies defeated";
            EndBattle();
        }
        else
        {
            state = BattleState.EnemyTurn;
            StateName.text = "Monster Turn";
            StartCoroutine(EnemyTurn());
        }
    }
    public void OnHealButton()
    {
        if (state != BattleState.PlayerTurn) return;
        StartCoroutine(HealthSpell());
    }
    IEnumerator HealthSpell()
    {
        state = BattleState.Busy;
        StateName.text = "Hero Action";





        yield return new WaitForSeconds(1f);


        playerUnit.TakeDamage(playerUnit.HealSpell());

        yield return new WaitForSeconds(1f);

        state = BattleState.EnemyTurn;
        StateName.text = "Monster Turn";
        StartCoroutine(EnemyTurn());
        

    }

    public void OnSwordButton()
    {
        if (state != BattleState.PlayerTurn) return;
        StartCoroutine(SwordAttack());
    }
    IEnumerator SwordAttack()
    {
        state = BattleState.Busy;
        StateName.text = "Hero Action";



        

        yield return new WaitForSeconds(1f);

        
        enemyUnit.TakeDamage(playerUnit.SwordDamage());

        if(enemyUnit.Unskulled_Spider.currentHP <= 0)
        {
            enemyUnit.SkullSpiderDeathAnimation();
        }
        if (enemyUnit1.Fire_Spirit.currentHP <= 0)
        {
            enemyUnit1.FireSpiritDeathAnimation();
        }

        if (enemyUnit.Unskulled_Spider.currentHP <= 0 && enemyUnit1.Fire_Spirit.currentHP <=0)
        {
            state = BattleState.Won;
            StateName.text = "Enemies defeated";
            EndBattle();
        }
        else
        {
            state = BattleState.EnemyTurn;
            StateName.text = "Monster Turn";
            StartCoroutine(EnemyTurn());
        }

    }

    IEnumerator EnemyTurn()
    {
        state = BattleState.Busy;
        StateName.text = "Enemy Action";


        if (enemyUnit.Unskulled_Spider.currentHP > 0)
        {
            enemyUnit.StartSkullSpiderAnimation();

            yield return new WaitForSeconds(1.3f);

            playerUnit.TakeDamage(enemyUnit.EnemyAttackChoice());



            enemyUnit.StopSkullSpiderAnimation();
        }
        else
        {

            

        }


        if (enemyUnit1.Fire_Spirit.currentHP > 0)
        {
            enemyUnit1.StartFireSpiritAnimation();
            
            yield return new WaitForSeconds(0.8f);

            playerUnit.TakeDamage(enemyUnit1.EnemyAttackChoice());

            enemyUnit1.StopFireSpiritAnimation();
        }
        else
        {

        }

        

        

        if (playerUnit.Hero.currentHP <= 0)
        {
            state = BattleState.Lost;
            StateName.text = "Defeat";
            EndBattle();
        }
        else
        {
            state = BattleState.PlayerTurn;
            StateName.text = "Hero Turn";
            PlayerTurn();
        }
    }

    void EndBattle()
    {
        Debug.Log("Battle ended, you " + state);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
