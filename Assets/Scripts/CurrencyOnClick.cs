using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class CurrencyOnClick : MonoBehaviour
{
    int damage = 1;
    int fistpoints = 0;
    int GhostFists = 0;
    int DoTheDamage = 0;

    int totaldamage = 0;
    int BaseCost = 10;
    int BaseManHealth = 10;

    [SerializeField] TextMeshProUGUI amountOfCurrency;
    [SerializeField] TextMeshProUGUI purchaseText;
    [SerializeField] GameObject phantomFist;
    
    

    // Connected to CurrencyButton
    private void DoDamage()
    {
        if (GhostFists > 0)
        {
            totaldamage = GhostFists + damage;
        }
        else
        {
            totaldamage = damage;

        }
        BaseManHealth = BaseManHealth - damage;
    }

    public void addCurrency()
    {
        fistpoints++;
        amountOfCurrency.text = "You have " + fistpoints + " amount of Fistpoints!";
        Debug.Log("You pressed the button!");
    }

    // hitta något sätt att instantiate-a ghostfists
    // genom att göra en referens till komponenter först
    public void addGhostFists()
    {
        if (fistpoints >= BaseCost) 
        {
            static Object Instantiate(GameObject phantomFist, Vector3   );
        }
        else
        {

        }
    }

    public void moreFistPower()
    {
        if (fistpoints == BaseCost)
        {
            
        }
    }
}
