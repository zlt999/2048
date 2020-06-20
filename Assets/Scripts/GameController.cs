using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static MonoBehaviour instance { get; private set; }

    private int currentMoney;

    void Awake()
    {
        instance = this;
        //DontDestroyOnLoad(gameObject);

        currentMoney = 0;
    }

    public void AddMoney(int amount)
    {
        currentMoney += amount;
        UIManager.instance.UpdateMoneyDisplay(currentMoney);
    }
    public int GetMoney() { return currentMoney; }
}
