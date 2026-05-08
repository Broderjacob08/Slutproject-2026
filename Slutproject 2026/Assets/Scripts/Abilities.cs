using UnityEngine;

 public class Abilities : MonoBehaviour
{
    string name;
    int dmg;
    int cost;
    int targetLimit;

    public Abilities(string name, int dmg, int cost, int targetLimit)
    {
        this.name = name;
        this.dmg = dmg;
        this.cost = cost;
        this.targetLimit = targetLimit;
    }
}
