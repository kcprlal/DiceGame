using UnityEngine;

interface IOpponentStrategy{
    public void PlayTurn(DiceSet dSet);
    public string GetTargetName();
}