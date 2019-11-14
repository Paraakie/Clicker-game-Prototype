using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeOneCostText : MonoBehaviour
{
    public Text upgradeOneCostText;

    private int upgradeOneCost = -100;

    // Update is called once per frame
    void Update()
    {
        upgradeOneCostText.text = upgradeOneCost.ToString();
    }

    /*
     * Getters and Setters 
     */
    public int GetUpgradeOneCost()
    {
        return upgradeOneCost;
    }

    public void SetUpgradeOneCost(int value)
    {
        upgradeOneCost = value;
    }

}
