using System;
using Unity.VisualScripting;
using UnityEngine;

public class ThrowManager
{
    private int throwsLeft;
    private int rerollsLeft;
    private bool[] keepFlags;
    public ThrowManager()
    {
        throwsLeft = 3;
        rerollsLeft = 3;
        keepFlags = new bool[5] { true, true, true, true, true };
    }
    public bool Reroll(DiceSet dSet)
    {
        if (rerollsLeft>0)
        {
            for (int i = 0; i < 5; ++i)
            {
                if (keepFlags[i]) dSet.DiceRoll(i);
            }
            rerollsLeft--;
            return true;
        }
        return false;
    }
    public bool Throw(DiceSet dSet){
        if(throwsLeft>0){
           for (int i = 0; i < 5; ++i)
            {
                dSet.DiceRoll(i);
            } 
            throwsLeft--;
            return true;
        }
        return false;
    }
}