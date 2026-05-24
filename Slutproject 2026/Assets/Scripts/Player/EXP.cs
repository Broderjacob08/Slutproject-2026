using UnityEngine;

public class EXP : MonoBehaviour
{
    public int currentXP = 0;
    //public bool hasDied = false;
    public void GainExperience(int amount)
    {
            currentXP += amount;
            Debug.Log("Gained " + currentXP + " XP!!");
    }
}
