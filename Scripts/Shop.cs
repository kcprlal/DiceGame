using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public class Shop
{
    private readonly List<Booster> availableBoosters;
    private List<Booster> stock;
    private List<int> prices;
    //test functions
    public void printstock()
    {
        foreach (var s in stock)
        {
            Debug.Log($"przedmiot w sklepie: {s}");
        }
        foreach (var p in prices)
        {
            Debug.Log($"cena przedmiot w sklepie: {p}");
        }
        RefreshInventory();
        foreach (var s in stock)
        {
            Debug.Log($"przedmiot w sklepie: {s}");
        }
        foreach (var p in prices)
        {
            Debug.Log($"cena przedmiot w sklepie: {p}");
        }

    }

    //end of test

    public Shop()
    {
        availableBoosters = new List<Booster>();
        BoosterCreator boosterCreator = new BoosterCreator();
        availableBoosters = boosterCreator.CreateBoosters();
        stock = new List<Booster>();
        for (int i = 0; i < 3; ++i)
        {
            stock.Add(availableBoosters[Random.Range(0, availableBoosters.Count)]);
        }
        prices = new List<int> { 10, 10, 10 };
    }
    public void RefreshInventory()
    {
        stock.Clear();
        for (int i = 0; i < 3; ++i)
        {
            stock.Add(availableBoosters[Random.Range(0, availableBoosters.Count)]);
        }
        prices.Clear();
        for (int i = 0; i < 3; ++i)
        {
            prices.Add(Random.Range(8, 19));
        }
    }
    public bool PurchaseBooster(Player player, int index)
    {
        if (player.Coins >= prices[index] && player.AddBooster(stock[index]))
        {
            player.ChangeCoins(-prices[index]);
            return true;
        }
        return false;
    }
}