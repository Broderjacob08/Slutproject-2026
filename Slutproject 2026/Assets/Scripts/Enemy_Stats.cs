using UnityEngine;
//Alexander

public class Enemy_Stats : Unit_Stats
{
    public int baseModifier;
    public Enemy_Stats(string unit_name, int maxHP, int currentHP, int baseModifier) : base(unit_name, maxHP, currentHP)
    {
        this.baseModifier = baseModifier;
    }
}
