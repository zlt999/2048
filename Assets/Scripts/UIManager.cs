using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance { get; private set; }

    public Text moneyText;

    void Awake()
    {
        instance = this;
    }

    public void UpdateMoneyDisplay(int currentMoney)
    {
        moneyText.text = currentMoney.ToString();
    }
}
