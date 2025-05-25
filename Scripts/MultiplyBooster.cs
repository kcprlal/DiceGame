using UnityEngine;

public class MultiplyBooster : Booster
{
    public MultiplyBooster(string name, int bonus)
    {
        Name = name;
        this.bonus = bonus;
    }
    public override int Apply(int score)
    {
        return score * bonus;
    }
}