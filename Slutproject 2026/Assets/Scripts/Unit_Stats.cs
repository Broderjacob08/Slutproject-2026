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

    public TextMeshProUGUI HPCounter;
    private void Start()
    {
        
    }

    public void TakeDamage(int amount)
    {
        currentHP -= amount;
        if (currentHP < 0) currentHP = 0;
    }
    private void Update()
    {
        HPCounter.text = currentHP + "of" + maxHP;
    }
    
}
