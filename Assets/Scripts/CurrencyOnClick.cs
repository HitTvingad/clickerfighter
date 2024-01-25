using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrencyOnClick : MonoBehaviour
{
    int fistpoints = 0;
    Button CurrencyButton;


    void Start()
    {
         CurrencyButton = GetComponent("The Currency Button") as Button;
    }

    public void AddCurrency()
    {
        fistpoints++;
    }
}