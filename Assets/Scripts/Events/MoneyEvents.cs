using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyEvents
{
    public event Action<int> onMoneyGained;
    public void MoneyGained(int money)
    {
        if (onMoneyGained != null)
        {
            onMoneyGained(money);
        }
    }

    public event Action<int> onMoneyChange;
    public void MoneyChange(int money)
    {
        if (onMoneyChange != null)
        {
            onMoneyChange(money);
        }
    }
}