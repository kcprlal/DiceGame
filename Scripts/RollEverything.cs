using UnityEngine;

public class RollEverything : IOpponentStrategy
{
    private string description;
    public RollEverything()
    {
        description = "Roll Everything";
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