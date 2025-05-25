using System.Collections.Generic;
using UnityEngine;

public class BoosterCreator
{
    private List<Booster> boosterList;
    public BoosterCreator()
    {
        boosterList = new List<Booster>{
            new FlatBooster("plus 5", 5),
            new FlatBooster("plus 10", 10),
            new FlatBooster("plus 20", 20),
            new FlatBooster("plus 30", 30),
            new FlatBooster("plus 40", 40),
            new FlatBooster("plus 50", 50),
            new MultiplyBooster("times 2", 2),
            new MultiplyBooster("times 3", 3),
            new MultiplyBooster("times 4", 4),
            new MultiplyBooster("times 5", 5),
            new MultiplyBooster("times 6", 6),
            new MultiplyBooster("times 7", 7),
            new ComboBooster("combo 2", 2),
            new ComboBooster("combo 3", 3),
            new ComboBooster("combo 4", 4),
            new ComboBooster("combo 5", 5),
            new ComboBooster("combo 6", 6),
            new ComboBooster("combo 7", 7)
        };
    }
    public List<Booster> CreateBoosters()
    {
        return boosterList;
    }
}
