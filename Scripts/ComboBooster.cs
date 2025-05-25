using UnityEngine;

public class ComboBooster : Booster
{
    public ComboBooster(string name, int bonus)
    {
        Name = name;
        this.bonus = bonus;
    }
    public override int Apply(int score)
    {
        score += bonus * 10;
        return score * bonus/2;
    }
}