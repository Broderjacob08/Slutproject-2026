using UnityEngine;

 public class Abilities : MonoBehaviour
{
    //Ian
    string name;
    int dmg;
    int cost;
    int targetLimit;

    public Abilities(string name, int Abilitydmg, int cost, int targetLimit)
    {
        this.name = name;
        this.dmg = dmg;
        this.cost = cost;
        this.targetLimit = targetLimit;
    }

    public virtual void use()
    {

    }
}
