using UnityEngine;
using System;

public class DiceTestRunner : MonoBehaviour
{
    void Start()
    {
        Shop shop = new Shop();
        Player player = new Player();
        player.ChangeCoins(1000);
        shop.PurchaseBooster(player, 0);
        shop.PurchaseBooster(player, 1);
        shop.PurchaseBooster(player, 2);
        shop.RefreshInventory();
        shop.PurchaseBooster(player, 0);
        shop.PurchaseBooster(player, 1);
        shop.PurchaseBooster(player, 2);
        shop.RefreshInventory();
        shop.PurchaseBooster(player, 0);
        shop.PurchaseBooster(player, 1);
        shop.PurchaseBooster(player, 2);
        Debug.Log($"portfel {player.Coins}");
        player.showinv();
        player.RecalculateBoost();
        player.printscore();
    }
}
