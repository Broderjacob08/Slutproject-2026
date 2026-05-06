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


    public Unit_Stats playerUnit;
    public Unit_Stats enemyUnit;
    void Start()
    {
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
    public void OnAttackButton()
    {
        if (state != BattleState.PlayerTurn) return;
        StartCoroutine(PlayerAttack());
    }
    System.Collections.IEnumerator PlayerAttack()
    {
        state = BattleState.Busy;
        StateName.text = "Hero Action";

        enemyUnit.TakeDamage(playerUnit.damage);

        yield return new WaitForSeconds(1f);

        if(enemyUnit.currentHP <= 0)
        {
            state = BattleState.Won;
            StateName.text = "Enemy defeated";
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

        yield return new WaitForSeconds(1f);

        playerUnit.TakeDamage(enemyUnit.damage);

        if (playerUnit.currentHP <= 0)
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
