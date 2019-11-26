using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrade1CostText : MonoBehaviour
{
    public Text upgrade1CostText;

    //Upgrade-COST Array
    private int[] upgrade1Cost = new[] {
        -100,
        -500
    };


    /*
     * Needs to be moved
     */ 
    //Upgrade-PURCHASED Array
    private bool[] upgradePurchased = new[]
    {
        false,
        false
    };


    // Update is called once per frame
    void Update()
    {
        /**
         * Will be moved to UpgradeUpdate
         */ 

        // Get value of newest unpurchased upgrade in Array
        int newestUpgrade = get1stFalseIndex(upgradePurchased);
        
        // Update upgrade1Cost Text
        upgrade1CostText.text = upgrade1Cost[newestUpgrade].ToString() + " Wood";


    }


    // Takes bool array and finds first false entry
    public int get1stFalseIndex(bool[] boolArray)
    {
        for (int i = 0; i < boolArray.Length; i++)
        {
            if (boolArray[i] == false)
            {
                //return correct index
                return i;
            }
        }


        return -1; // if no entry with "false" is found
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
