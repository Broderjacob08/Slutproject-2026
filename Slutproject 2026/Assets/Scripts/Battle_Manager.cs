using TMPro;
using UnityEngine;
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

    

    public Player playerUnit;
    public UnSkull_SkullSpider enemyUnit;
    public FireSprite enemyUnit1;
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
        //Fixa UI för actions
    }
    public void OnWaveRageButton()
    {
        if (state != BattleState.PlayerTurn) return;
        StartCoroutine(WaveRageSpell());
    }
    System.Collections.IEnumerator WaveRageSpell()
    {
        state = BattleState.Busy;
        StateName.text = "Hero Action";



        yield return new WaitForSeconds(1f);

        enemyUnit.TakeDamage(playerUnit.WaveRage());
        enemyUnit1.TakeDamage(playerUnit.WaveRage());

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
    System.Collections.IEnumerator HealthSpell()
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
    System.Collections.IEnumerator SwordAttack()
    {
        state = BattleState.Busy;
        StateName.text = "Hero Action";



        

        yield return new WaitForSeconds(1f);

        
        enemyUnit.TakeDamage(playerUnit.SwordDamage());

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

    System.Collections.IEnumerator EnemyTurn()
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
            yield return new WaitForSeconds(1f);

            playerUnit.TakeDamage(enemyUnit1.EnemyAttackChoice());
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
