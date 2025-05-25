using System.Collections.Generic;
using UnityEngine;

public class BoosterInventory
{
    public List<Booster> boosters { get; private set; }
    //debugowanie
    public void print()
    {
        foreach (var u in boosters)
        {
            Debug.Log($"booster: {u}");
        }
    }
    //koniec
    public BoosterInventory()
    {
        boosters = new List<Booster>();
    }
    public void AddBooster(Booster booster)
    {
        boosters.Add(booster);
    }
    public void Clear()
    {
        boosters.Clear();
    }
}
