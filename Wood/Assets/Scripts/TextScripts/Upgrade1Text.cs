using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrade1Text : MonoBehaviour
{
    public Text upgrade1Text;
    private string upgradeString = "Gain +5 WpC(Branches)";

    
    // Update is called once per frame
    void Update()
    {
        upgrade1Text.text = upgradeString; // Call setter to change in UpdateUpgrades Script
    }

    /*
     * Getters and Setters
     */ 
     public string GetUpgradeString()
    {
        return upgradeString;
    }

    public void SetUpgradeString(string value)
    {
        upgradeString = value;
    }

    
}
