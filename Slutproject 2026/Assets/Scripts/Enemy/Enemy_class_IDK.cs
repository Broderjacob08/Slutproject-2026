using UnityEngine;

public class Enemy_class_IDK : MonoBehaviour
{
    public Enemy_Stats Enemy_Stats;

    private void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            
            Battle_Manager.instance.Target = this;
        }
        Debug.Log("new target");
    }

    public virtual void DeathAnimation()
    {
        GetComponent<Animator>().SetBool("Death", true);
    }
    public void StopAttackAnimation()
    {
        GetComponent<Animator>().SetBool("Attack", false);
    }
    public void StartAttackAnimation()
    {
        GetComponent<Animator>().SetBool("Attack", true);
    }
    public virtual int EnemyAttackChoice()
    {
        return 0;
    }
}
