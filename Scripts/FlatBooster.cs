using UnityEngine;

public class FlatBooster : Booster
{
    public FlatBooster(string name, int bonus){
        Name = name;
        this.bonus = bonus;
    }
    public override int Apply(int score)
    {
        return score + bonus;
    }
}
