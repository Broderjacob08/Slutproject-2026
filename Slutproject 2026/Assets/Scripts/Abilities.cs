using UnityEngine;

 public class Abilities : MonoBehaviour
{
    //Ian
    string name;
    int Abilitydmg;
    int cost;
    int targetLimit;

    public Abilities(string name, int Abilitydmg, int cost, int targetLimit)
    {
        this.name = name;
        this.Abilitydmg = Abilitydmg;
        this.cost = cost;
        this.targetLimit = targetLimit;
    }

    public virtual void use()
    {

    }
}
