using UnityEngine;

public class NoThrowsEffect : IPlayerEffect
{
    private string description;
    public NoThrowsEffect()
    {
        description = "0 throws";
    }
    public void ApplyEffect(Player p)
    {
        p.SetThrows(1);
    }
    public string Description()
    {
        return description;
    }
}