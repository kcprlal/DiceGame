using UnityEngine;

public class Player
{
    public int coins;
    public int Coins
    {
        get { return coins; }
        private set { coins = value; }
    }
    public BoosterInventory boosterInv { get; private set; }
    private DiceSet diceSet;
    private int throwSize;
    private int rerollSize;
    private long currentBoost;
    //debugowanie
    public void showinv()
    {
        boosterInv.print();
    }
    public void printscore()
    {
        Debug.Log($"bonus: {currentBoost}");
    }

    //koniec
    public Player()
    {
        coins = 0;
        boosterInv = new BoosterInventory();
        diceSet = new DiceSet();
        throwSize = 3;
        rerollSize = 3;
        currentBoost = 10;
    }
    public void ChangeCoins(int amount)
    {
        coins += amount;
    }
    public bool AddBooster(Booster booster)
    {
        if (boosterInv.boosters.Count > 10)
        {
            return false;
        }
        boosterInv.AddBooster(booster);
        return true;
    }
    public void RecalculateBoost()
    {
        BoosterCalculator boosterCalculator = new BoosterCalculator();
        currentBoost = boosterCalculator.CountBoost(boosterInv);
    }
    public void SetRolls(int i)
    {
        rerollSize = i;
    }
    public void SetThrows(int i)
    {
        throwSize = i;
    }
    public void HalfBooster()
    {
        currentBoost /= 2;
    }
}
