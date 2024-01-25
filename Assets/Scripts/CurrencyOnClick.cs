using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class CurrencyOnClick : MonoBehaviour
{
    int fistpoints = 0;
    [SerializeField] TextMeshProUGUI amountOfCurrency;


   

    // Connected to CurrencyButton
    public void addCurrency()
    {
        fistpoints++;
        amountOfCurrency.text = "You have " + fistpoints + " amount of Fistpoints!";
        Debug.Log("You pressed the button!");
    }

}
