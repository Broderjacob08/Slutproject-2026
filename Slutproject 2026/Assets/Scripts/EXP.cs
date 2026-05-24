using UnityEngine;

public class EXP : Battle_Manager
{
    int currentXP = 0;

    public void GainExperience()
    {
        if(hasDied == true) //när fiende dör sker detta
        {
            Debug.Log("enemy died");
        }
    }
}
