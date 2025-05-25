using UnityEngine;

public class GreedyHigh : IOpponentStrategy
{
    private string description;
    public GreedyHigh()
    {
        description = "Greedy High";
    }
    public void PlayTurn(DiceSet dSet)
    {
        //dodac
    }
    public string GetTargetName()
    {
        return description;
    }
}