using UnityEngine;

public class CurrentScoreHalfedEffect : IPlayerEffect
{
    private string description;
    public CurrentScoreHalfedEffect()
    {
        description = "Current score is halfed";
    }
    public void ApplyEffect(Player p)
    {
        p.HalfBooster();
    }
    public string Description()
    {
        return description;
    }
}