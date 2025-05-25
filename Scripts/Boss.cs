using System.Collections.Generic;
using UnityEngine;

public class Boss : Opponent
{
    private List<IPlayerEffect> effects;
    private IPlayerEffect currentEffect;
    public Boss(int level) : base(level) {
        effects = new List<IPlayerEffect>{
            new NoRerollsEffect(),
            new NoThrowsEffect(),
            new CurrentScoreHalfedEffect()
        };
        currentEffect = effects[Random.Range(1,4)];
     }
}