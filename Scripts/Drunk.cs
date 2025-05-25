using UnityEngine;

public class Drunk : IOpponentStrategy
{
    private string description;
    public Drunk()
    {
        description = "Drunk";
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