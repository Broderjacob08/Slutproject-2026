using JetBrains.Annotations;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem;
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

    public static Battle_Manager instance;

    public Enemy_class_IDK Target;

    public Player playerUnit;
    public Enemy_class_IDK enemyUnit;
    public Enemy_class_IDK enemyUnit1;

    public LayerMask enemyLayer;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }
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

        Target = enemyUnit;
        

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

        enemyUnit.Enemy_Stats.TakeDamage(playerUnit.WaveRage());
        enemyUnit1.Enemy_Stats.TakeDamage(playerUnit.WaveRage());
        if (enemyUnit.Enemy_Stats.currentHP <= 0)
        {
            enemyUnit.DeathAnimation();
        }
        if (enemyUnit1.Enemy_Stats.currentHP <= 0)
        {
            enemyUnit1.DeathAnimation();
        }

        WaveCooldown = 3;

        if (enemyUnit.Enemy_Stats.currentHP <= 0 && enemyUnit1.Enemy_Stats.currentHP <= 0)
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

        
        Target.Enemy_Stats.TakeDamage(playerUnit.SwordDamage());

        if(Target.Enemy_Stats.currentHP <= 0)
        {
            Target.DeathAnimation();
        }
        

        if (Target.Enemy_Stats.currentHP <= 0)
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


        if (enemyUnit.Enemy_Stats.currentHP > 0)
        {
            enemyUnit.StartAttackAnimation();

            yield return new WaitForSeconds(1.3f);

            playerUnit.TakeDamage(enemyUnit.EnemyAttackChoice());



            enemyUnit.StopAttackAnimation();
        }
        else
        {

            

        }


        if (enemyUnit1.Enemy_Stats.currentHP > 0)
        {
            enemyUnit1.StartAttackAnimation();
            
            yield return new WaitForSeconds(0.8f);

            playerUnit.TakeDamage(enemyUnit1.EnemyAttackChoice());

            enemyUnit1.StopAttackAnimation();
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
        //if(Physics2D.OverlapCircle())
    }
}
