using System.Collections.Generic;
using UnityEngine;

public class DiceSet
{
    private List<Dice> dices;
    public DiceSet()
    {
        dices = new List<Dice>();
        for (int i = 0; i < 5; i++)
        {
            dices.Add(new Dice());
        }
    }
    public void DiceRoll(int id)
    {
        dices[id].Roll();
    }
    public List<int> GetValues()
    {
        List<int> values = new List<int>();
        foreach (var die in dices)
        {
            values.Add(die.GetValue());
        }
        return values;
    }

}
