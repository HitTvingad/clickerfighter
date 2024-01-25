using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
public enum Weapons
{
    Unarmed,
    BoxingGlove,
    Dusters,
    total
}
public class CurrencyOnClick : MonoBehaviour
{
    public int fistpoints = 0;
    [SerializeField] TextMeshProUGUI amountOfCurrency;
    Weapons weaponsHeld = Weapons.Unarmed;


    public void Update()
    {
        amountOfCurrency.text = "You have " + fistpoints.ToString() + " amount of Fistpoints!";
    }
    //Ivar Sakerna. Lite goofy
    public void WeaponUpgrade()
    {
        Debug.Log("buton");
        if (fistpoints >= 10)
        {
            weaponsHeld = Weapons.BoxingGlove;
            Debug.Log("Glove");
        }
    }
    //Ivar Sakerna. Lite goofy


    // Connected to CurrencyButton
    public void addCurrency()
    {
        fistpoints += 1 + (int)weaponsHeld;

        Debug.Log("You pressed the button!");
    }
}
