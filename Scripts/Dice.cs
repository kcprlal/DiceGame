using UnityEngine;

public class Dice
{
    private int value;
    public Dice(){
        value = 0;
    }
    public void Roll(){
        value = Random.Range(1,7);
        Debug.Log($"Wylosowano: {value}");
    }
    public int GetValue(){
        return value;
    }
}
