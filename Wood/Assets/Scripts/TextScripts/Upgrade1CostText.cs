using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrade1CostText : MonoBehaviour
{
    public Text upgrade1CostText;

    private int[] upgrade1Cost = new[] {
        -100,
        -500
    };

    private bool[] upgradePurchased = new[]
    {
        false,
        false
    };

    

    // Update is called once per frame
    void Update()
    {
        upgrade1CostText.text = upgrade1Cost.ToString();
    }

    /*
     * Getters and Setters 
     */

    //upgrade1Cost
    public int[] GetUpgradeOneCost()
    {
        return upgrade1Cost;
    }

    public void SetUpgradeOneCost(int[] value)
    {
        upgrade1Cost = value;
    }

    //upgradePurchased
    public bool[] GetUpgradePurchased()
    {
        return upgradePurchased;
    }

    public void SetUpgradePurchased(bool[] value)
    {
        upgradePurchased = value;
    }

}
