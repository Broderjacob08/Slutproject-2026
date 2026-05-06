using UnityEngine;
//Alexander
public class Unit_Stats : MonoBehaviour
{
    public string unitName;
    public int maxHP;
    public int currentHP;

    public void TakeDamage(int amount)
    {
        currentHP -= amount;
        if (currentHP < 0) currentHP = 0;
    }
}
