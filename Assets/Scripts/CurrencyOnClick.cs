using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
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
    [SerializeField] Sprite punchedSprite;
    [SerializeField] Sprite unpunchedSprite;

    [SerializeField] TextMeshProUGUI amountOfCurrency;
    Weapons weaponsHeld = Weapons.Unarmed;

    public void Update()
    {
        amountOfCurrency.text = "You have " + fistpoints.ToString() + " amount of Fistpoints!";

        Debug.Log(fistpoints);
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

    public int fistpoints = 0;
    int damage = 1;
    int GhostFists = 0;
    int DoTheDamage = 0;
    int totaldamage = 0;
    int BaseCost = 10;
    int ghostCost = 10;
    int BaseManHealth = 10;

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
        fistpoints += 1 + (int)weaponsHeld;
        Debug.Log("You pressed the button!");

        UnityEngine.UI.Image imageComponent = gameObject.GetComponent<UnityEngine.UI.Image>();
        imageComponent.sprite = punchedSprite;
        Invoke("NotPunched", 2f);
    }

    private void NotPunched()
    {
        UnityEngine.UI.Image imageComponent = gameObject.GetComponent<UnityEngine.UI.Image>();
        imageComponent.sprite = unpunchedSprite;
    }

    // hitta n�got s�tt att instantiate-a ghostfists
    // genom att g�ra en referens till komponenter f�rst
    public void addGhostFists()
    {
        if (fistpoints >= ghostCost) 
        {
             Instantiate(phantomFist, transform.position, Quaternion.identity);
            GhostFists += 1;
            fistpoints -= ghostCost;
            ghostCost += 5;
        }
    }

    public void moreFistPower()
    {
        if (fistpoints == BaseCost)
        {
            
        }
    }
}
