using UnityEngine;

 public class Abilities : MonoBehaviour
{
    //Ian
    //Alexander (Gjorde variabler public och ändrade dmg till Abilitydmg)
    public string name;
    public int Abilitydmg;
    public int cost;
    public int targetLimit;

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
