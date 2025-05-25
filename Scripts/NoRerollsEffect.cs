using UnityEngine;

public class NoRerollsEffect : IPlayerEffect
{
    private string description;
    public NoRerollsEffect()
    {
        description = "0 rerolls";
    }
    public void ApplyEffect(Player p)
    {
        p.SetRolls(1);
    }
    public string Description()
    {
        return description;
    }
}