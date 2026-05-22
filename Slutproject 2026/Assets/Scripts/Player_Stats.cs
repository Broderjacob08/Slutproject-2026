using UnityEngine;
//Alexander

public class Player_Stats : Unit_Stats
{
    public int basedmg;
    public int XP;
    
    
    public Player_Stats(string unit_name, int maxHP, int currentHP, int basedmg, int XP) : base(unit_name, maxHP, currentHP)
    {
        this.basedmg = basedmg;
        this.XP = XP;
    }
}
