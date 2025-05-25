using UnityEngine;

public abstract class Booster
{
    public string Name{get; protected set; }
    protected int bonus;
    public abstract int Apply(int score);
}
