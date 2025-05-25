using UnityEngine;
using System.Collections.Generic;

public abstract class Opponent
{
    private int opponentBooster;
    private List<IOpponentStrategy> strategies;
    private IOpponentStrategy currentStrategy;
    private DiceSet diceSet;
    public Opponent(int level)
    {
        opponentBooster = level * level;
        strategies = new List<IOpponentStrategy>{
            new RollEverything(),
            new GreedyHigh(),
            new Drunk(),
            new Blind()
        };
        currentStrategy = strategies[Random.Range(1, 5)];
        diceSet = new DiceSet();
    }
    public void PlayTurn()
    {
        //dodac
    }
}