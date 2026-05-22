using UnityEngine;

 public class Abilities : MonoBehaviour
{
    //Ian

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
}
