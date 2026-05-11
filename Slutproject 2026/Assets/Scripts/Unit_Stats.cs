using TMPro;
using UnityEngine;
//Alexander
public class Unit_Stats : MonoBehaviour
{
    public string unitName;
    public int maxHP;
    public int currentHP;
    public int damage;

    public TextMeshProUGUI HPCounter;
    private void Start()
    {
        HPCounter = GetComponent<TextMeshProUGUI>();
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
