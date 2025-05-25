using UnityEngine;

public class BoosterCalculator
{
    public long CountBoost(BoosterInventory binv)
    {
        int score = 0;
        foreach (var b in binv.boosters)
        {
            score = b.Apply(score);
        }
        return score;
    }
}
