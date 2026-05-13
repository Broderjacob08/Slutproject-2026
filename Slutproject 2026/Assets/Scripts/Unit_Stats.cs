using TMPro;
using UnityEngine;
//Alexander
public class Unit_Stats : MonoBehaviour
{
    public string unitName;
    public int maxHP;
    public int currentHP;
    

    public Unit_Stats(string unitName, int maxHP, int currentHP)
    {
        this.unitName = unitName;
        this.maxHP = maxHP;
        this.currentHP = currentHP;
    }

    
    private void Start()
    {
        
    }

    
    
}
