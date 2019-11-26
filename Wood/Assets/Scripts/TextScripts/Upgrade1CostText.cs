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
        int newestUpgrade = 0; //implement function that updates this value


        upgrade1CostText.text = upgrade1Cost[newestUpgrade].ToString() + " Wood";
    }

    /*
     * Getters and Setters 
     */

    //upgrade1Cost
    public int GetUpgradeOneCost(int index)
    {
        return upgrade1Cost[index];
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

    public void SetUpgradePurchased(bool value, int index)
    {
        upgradePurchased[index] = value;
    }

}
