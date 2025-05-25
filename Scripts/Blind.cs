using UnityEngine;

public class Blind : IOpponentStrategy
{
    private string description;
    public Blind()
    {
        description = "Blind";
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